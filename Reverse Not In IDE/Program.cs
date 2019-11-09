using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Not_In_IDE
{
    class Program
    {

        static void Main()
        {
            Intro();
            string TheInput = Console.ReadLine();
            Reverse B5 = new Reverse();
            Console.WriteLine("-----------------------");
            Console.WriteLine("The Output Reversed Is: {0}", B5.Reverser(TheInput));
            Console.WriteLine("-----------------------");
            Ending();
        }

        public static void Intro()
        {
            Intro.IntroNested B6 = new Intro.IntroNested();
            Console.WriteLine(B6.Introduction());
        }

        public static void Ending()
        {
            Ending.EndingNested B7 = new Ending.EndingNested();
            Console.WriteLine(B7.Ended());
        }
        
       
    }
}
