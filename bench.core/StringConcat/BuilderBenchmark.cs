using System;
using System.Text;
using BenchmarkDotNet.Attributes;
using StringHelper;

namespace bench.core.StringConcat
{
    [MemoryDiagnoser]
    public class BuilderBenchmark
    {
        [Params(10, 100, 1000)]
        public int Count { get; set; }

        [Benchmark]
        public string UseString()
        {
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
                result += "\"/>";
            }
            result += "</Customers>";
            return result;
        }

        [Benchmark]
        public string UseStringBuilder()
        {
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
                sb.Append("\"/>");
            }
            sb.Append("</Customers>");
            return sb.ToString();
        }
    }
}
