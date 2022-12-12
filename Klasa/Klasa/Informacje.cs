using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Klasa
{
    internal class Informacje
    {

        public static void informacje(int[] zycie, int dzien)
        {
            Console.WriteLine("             ");
            Console.WriteLine($"<><><><><><><><><><><><><>  Jaką pracę wybierasz {dzien} dnia?  <><><><><><><><><><><><><>");
            Console.WriteLine("             ");
            Console.WriteLine("" +
                " * malowanie trawy                 - 1\n" +
                " * odgarnianie śniegu kosiarką     - 2\n" +
                " * zamiatanie kałuży               - 3");
            Console.WriteLine("              ");
            Console.WriteLine($"twoja siła psychiki {zycie[0]}, stan zdrowia {zycie[1]}, punkty energii {zycie[2]}, siła {zycie[3]}");
            Console.WriteLine("        ");

         
        }

    }
}
