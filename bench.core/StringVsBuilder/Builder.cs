using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace bench.core
{
    [RyuJitX64Job]
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    public class Builder
    {

        [Params(1000)]
        public int Count { get; set; }

        [Benchmark]
        public string GetConcatenated()
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
        public string GetBuilder()
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
    }
}
