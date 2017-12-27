using BenchmarkDotNet.Running;

namespace MicroBenchmarking
{
    public class Program
    {

        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Mappers>();
        }
    }



}
