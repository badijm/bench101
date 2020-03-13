using System;
using System.Buffers;
using System.Diagnostics;

namespace bench.core.StringVsBuilder
{
    public ref struct ValueStringBuilder
    {
        private char[] _arrayToReturnToPool;
        private Span<char> _chars;
        private int _pos;
        public ValueStringBuilder(Span<char> initialBuffer)
        {
            _arrayToReturnToPool = null;
            _chars = initialBuffer;
            _pos = 0;
        }
        public ref char this[int index] => ref _chars[index];
        public void Append(char c)
        {
            int pos = _pos;
            if (pos < _chars.Length)
            {
                _chars[pos] = c;
                _pos = pos + 1;
            }
            else
                GrowAndAppend(c);
        }
        private void GrowAndAppend(char c)
        {
            Grow(1);
            Append(c);
        }

        private void Grow(int requiredAdditionalCapacity)
        {
            Debug.Assert(requiredAdditionalCapacity > 0);
            char[] poolArray = ArrayPool<char>.Shared.Rent(Math.Max(_pos +
                                requiredAdditionalCapacity, _chars.Length * 2));
            _chars.CopyTo(poolArray);
            char[] toReturn = _arrayToReturnToPool;
            _chars = _arrayToReturnToPool = poolArray;
            if (toReturn != null)
            {
                ArrayPool<char>.Shared.Return(toReturn);
            }
        }
        public void Dispose()
        {
            char[] toReturn = _arrayToReturnToPool;
            if (toReturn != null)
            {
                ArrayPool<char>.Shared.Return(toReturn);
            }
        }
        public void Append(string str)
        {
            foreach (char c in str)
                Append(c);
        }
        public override string ToString() => new string(_chars.Slice(0, _pos));
    }
}