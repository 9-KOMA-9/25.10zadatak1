using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak25._10._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hrvatska ima more";
            string s2 = "Italija je prvak svijeta";
            string s3 = s1.Substring(0, 8);
            string s4 = s2.Substring(7, s2.Length-7);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3 + s4);
            Console.ReadKey();
        }
    }
}
