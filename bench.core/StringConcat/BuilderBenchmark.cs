using System;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace bench.core.StringConcat
{
    [MemoryDiagnoser]
    public class BuilderBenchmark
    {
        [Params(1000)]
        public int Count { get; set; }

        [Benchmark]
        public string UseString()
        {
            Random rand = new Random();
            var result = "<Customers>";
            for (int i = 0; i <= Count; i++)
            {
                result += "<Customer Id=\"";
                result += i.ToString();
                result += "\" lastUpdateDate=\"";
                result += DateTime.Now.ToString();
                result += "\" branchId=\"";
                result += i.ToString();
                result += "\" firstName=\"";
                result += i.ToString(); ;
                result += "\" lastName=\"";
                result += "A customer with the Id: ";
                result += i.ToString();
                result += "\" ranking=\"";
                result += rand.Next(100).ToString();
                result += "\"/>";
            }
            result += "</Customers>";
            return result;
        }

        [Benchmark]
        public string UseStringBuilder()
        {
            Random rand = new Random();
            var sb = new StringBuilder("<Customers>");
            for (int i = 0; i <= Count; i++)
            {
                sb.Append("<Customer Id=\"");
                sb.Append(i.ToString());
                sb.Append("\" lastUpdateDate=\"");
                sb.Append(DateTime.Now.ToString());
                sb.Append("\" branchId=\"");
                sb.Append(i.ToString());
                sb.Append("\" firstName=\"");
                sb.Append(i.ToString());
                sb.Append("\" lastName=\"");
                sb.Append("A customer with the Id: ");
                sb.Append(i.ToString());
                sb.Append("\" ranking=\"");
                sb.Append(rand.Next(100).ToString());
                sb.Append("\"/>");
            }
            sb.Append("</Customers>");
            return sb.ToString();
        }

        [Benchmark]
        public string UseValueStringBuilder()
        {
            Span<char> initialBuffer = stackalloc char[32];
            using var builder = new ValueStringBuilder(initialBuffer);
            for (int i = 0; i <= Count; i++)
            {
                builder.Append("<Customer Id=\"");
                builder.Append(i.ToString());
                builder.Append("\" lastUpdateDate=\"");
                builder.Append(DateTime.Now.ToString());
                builder.Append("\" branchId=\"");
                builder.Append(i.ToString());
                builder.Append("\" firstName=\"");
                builder.Append(i.ToString());
                builder.Append("\" lastName=\"");
                builder.Append("A customer with the Id: ");
                builder.Append(i.ToString());
                builder.Append("\" ranking=\"");
                builder.Append("100");
                builder.Append("\"/>");
            }
            builder.Append("</Customers>");
            return builder.ToString();
        }
    }
}
