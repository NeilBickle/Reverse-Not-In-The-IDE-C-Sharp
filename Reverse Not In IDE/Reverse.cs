using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Not_In_IDE
{
    class Reverse
    {
        public string Reverser(string Input)
        {
            char[] chararray = Input.ToCharArray();
            string reversed = String.Empty;
            for (int b = chararray.Length - 1; b > -1; b--)
            {
                reversed += chararray[b];
            }
            return reversed;
        }
    }
}
