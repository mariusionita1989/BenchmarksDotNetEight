using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarksDotNetEight.Loop;
using BenchmarksDotNetEight.RandomGenerator;

namespace BenchmarksDotNetEight.Benchmarks
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class LoopOperationsDemo
    {
        private const int length = 1024 * 1024;
        private byte[]? byteInput = null;

        [GlobalSetup]
        public void GlobalSetup()
        {
            byteInput = RandomByteArrayGenerator.GenerateRandomByteArray(length);
        }

        [Benchmark(Baseline = true)]
        public void OptimizedUnsafeSpanWhileLoop()
        {
            if (byteInput != null)
                LoopOperations.OptimizedUnsafeSpanWhileLoop(byteInput.AsSpan());
        }
    }
}
