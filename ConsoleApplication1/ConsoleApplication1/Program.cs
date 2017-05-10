using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string UNB_Segment = "UNB+UNOC:3+5790000429158:14+7512964411111:14+160120:0555+00000283716971+################+PALLEDATA++1'";

            char[] delimeters = UNB_Segment.Substring(3, 1).ToCharArray();

            string[] fields = UNB_Segment.Split(delimeters);

            string UNB7 = "";

            if (fields.Length > 7) UNB7 = fields[7];

            Console.WriteLine("UNB7: " + UNB7);

            Console.WriteLine("\nAny key to continue..."); Console.ReadKey(true);
        }
    }
}
