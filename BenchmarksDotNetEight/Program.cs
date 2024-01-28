using BenchmarkDotNet.Running;
using BenchmarksDotNetEight.Benchmarks;
using BenchmarksDotNetEight.Loop;
using BenchmarksDotNetEight.RandomGenerator;

namespace BenchmarksDotNetEight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkRunner.Run<PrimeNumberDemo>();
            //BenchmarkRunner.Run<StringOperationsDemo>();
            //BenchmarkRunner.Run<RandomGeneratorDemo>();
            //BenchmarkRunner.Run<MemoryCopyDemo>();
            //BenchmarkRunner.Run<HashFunctionsDemo>();
            //BenchmarkRunner.Run<ArrayOperationsDemo>();
            //BenchmarkRunner.Run<CacheOperationsDemo>();
            //BenchmarkRunner.Run<FileOperationsDemo>();
            //BenchmarkRunner.Run<ReflectionOperationsDemo>();
            //BenchmarkRunner.Run<BinarySerializationDemo>();
            BenchmarkRunner.Run<LoopOperationsDemo>();
        }
    }
}
