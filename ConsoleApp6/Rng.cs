using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Rng
    {
        public static string GenerateValue()
        {
            string id = "8699038";

            return string.Join("", id.ToCharArray().OrderBy(x => x));
        }

        public static string GenerateValueStub()
        {
            Console.WriteLine("GenerateValueStub() called\n");

            return "8699038";
        }
    }
}
