﻿using System.Buffers;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace bench101
{
	[GcForce(false)]
	[RankColumn]
	[MemoryDiagnoser]
	public class PoolingBenchmark
	{
		[Params((int)1E+2, // 100 bytes
				(int)1E+3, // 1 000 bytes = 1 KB
				(int)1E+4, // 10 000 bytes = 10 KB
				(int)1E+5, // 100 000 bytes = 100 KB
				(int)1E+6, // 1 000 000 bytes = 1 MB
				(int)1E+7)] // 10 000 000 bytes = 10 MB
		public int SizeInBytes { get; set; }
		private ArrayPool<byte> fixedSizePool;

		[GlobalSetup]
		public void GlobalSetup()
			=> fixedSizePool = ArrayPool<byte>.Create(SizeInBytes + 1, 10);

		[Benchmark]
		public void Allocate()
		=> DeadCodeEliminationHelper.KeepAliveWithoutBoxing(new byte[SizeInBytes]);

		[Benchmark]
		public void RentAndReturn_Shared()
		{
			var pool = ArrayPool<byte>.Shared;
			byte[] array = pool.Rent(SizeInBytes);
			pool.Return(array);
		}

		[Benchmark]
		public void RentAndReturn_Aware()
		{
			var pool = fixedSizePool;
			byte[] array = pool.Rent(SizeInBytes);
			pool.Return(array);
		}
	}
}
