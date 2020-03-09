using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace bench101.Pooling
{
    public class DataClass
    {
        public short Age { get; internal set; }
        public Gender Gender { get; internal set; }
        public string Description { get; internal set; }
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct DataStruct
    {
        public short Age { get; internal set; }
        public Gender Gender { get; internal set; }
    }
}
