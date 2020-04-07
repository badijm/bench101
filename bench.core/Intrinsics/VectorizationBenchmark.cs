using BenchmarkDotNet.Attributes;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace bench.core.Intrinsics
{
    //https://github.com/EgorBo/IntrinsicsPlayground
    [RankColumn]
    [LegacyJitX86Job]
    [RyuJitX64Job]
    public class VectorizationBenchmark
    {
        private Vector4 vectorA, vectorB, vectorC = default;
        private MyCustomVector4 myVectorA, myVectorB, myVectorC = default;

        [Benchmark]
        public void CustomMul() => myVectorC = myVectorA * myVectorB;
        [Benchmark]
        public void SystemMul() => vectorC = vectorA * vectorB;

        [Benchmark]
        public void CustomAdd() => myVectorC = myVectorA + myVectorB;
        [Benchmark]
        public void SystemAdd() => vectorC = vectorA + vectorB;

    }

    public struct MyCustomVector4
    {
        public float X, Y, Z, W;
        public MyCustomVector4(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MyCustomVector4 operator *(MyCustomVector4 left, MyCustomVector4 right) => new MyCustomVector4(
            left.X * right.X,
            left.Y * right.Y,
            left.Z * right.Z,
            left.W * right.W);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MyCustomVector4 operator +(MyCustomVector4 left, MyCustomVector4 right) => new MyCustomVector4(
           left.X + right.X,
           left.Y + right.Y,
           left.Z + right.Z,
           left.W + right.W);
    }

}
