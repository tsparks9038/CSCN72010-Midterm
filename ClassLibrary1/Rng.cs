using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rng
    {
        public static string GenerateValue()
        {
            string id = "8699038";

            return string.Join("", id.ToCharArray().OrderBy(x => x));
        }
    }
}
