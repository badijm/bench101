namespace bench.core
{
    //VirtualSum can’t be inlined because it’s marked as a virtual method
    public class MethodInliningBenchmark
    {
        private const int N = 1000;
        private int[] x = new int[N];
        private int[] y = new int[N];
        private int[] z = new int[N];

        [Benchmark(Baseline = true)]
        public void NonVirtual()
        {
            for (int i = 0; i < z.Length; i++)
                z[i] = Sum(x[i], y[i]);
        }
        [Benchmark]
        public void Virtual()
        {
            for (int i = 0; i < z.Length; i++)
                z[i] = VirtualSum(x[i], y[i]);
        }
        private int Sum(int a, int b) => a + b;
        public virtual int VirtualSum(int a, int b) => a + b;
    }
}
