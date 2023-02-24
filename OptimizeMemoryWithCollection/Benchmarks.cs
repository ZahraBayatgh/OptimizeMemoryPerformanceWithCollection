using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace OptimizeMemoryPerformanceWithCollection
{
    [MemoryDiagnoser(false)]
    public class Benchmarks
    {
        [Benchmark]
        public Customer[] GetCustomer_Array()
        {
            return new Customer[] { };
        }
        [Benchmark]
        public Customer[] GetCustomer_EmptyArray()
        {
            return Array.Empty<Customer>();
        }
    }
}
