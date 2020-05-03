//using System;
//using System.Linq;
//using BenchmarkDotNet.Attributes;

//namespace bench.core.Span
//{
//    [RankColumn]
//    [MemoryDiagnoser]
//    public class SpanParserBenchmark
//    {
//        private const string FullName = "FirstName ModdleName LastName";

//        [Benchmark(Baseline = true)]
//        public void GetLastName()
//        {
//            NameParser.GetLastName(FullName);
//        }

//        [Benchmark]
//        public void GetLastNameUsingSubstring()
//        {
//            NameParser.GetLastNameUsingSubstring(FullName);
//        }

//        [Benchmark]
//        public void GetLastNameWithSpan()
//        {
//            NameParser.GetLastNameWithSpan(FullName);
//        }
//    }

//    public static class NameParser
//    {
//        public static string GetLastName(string fullName)
//        {
//            return fullName.Split(" ").LastOrDefault() ?? string.Empty;
//        }

//        public static string GetLastNameUsingSubstring(string fullName)
//        {
//            var lastSpaceIndex = fullName.LastIndexOf(" ", StringComparison.Ordinal);

//            return lastSpaceIndex == -1
//                ? string.Empty
//                : fullName.Substring(lastSpaceIndex + 1);
//        }

//        public static ReadOnlySpan<char> GetLastNameWithSpan(ReadOnlySpan<char> fullName)
//        {
//            var lastSpaceIndex = fullName.LastIndexOf(' ');

//            return lastSpaceIndex == -1
//                ? ReadOnlySpan<char>.Empty
//                : fullName.Slice(lastSpaceIndex + 1);
//        }
//    }

//}
