using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Klasa
{
    internal class MusiszCosWybrac
    {

        public static int[] Wybierz(int[] zycie)
        {
            zycie[0] -= 10;
            zycie[1] -= 10;
            zycie[2] -= 10;
            zycie[3] -= 10; 
            Console.WriteLine("Nie wybranie pracy zostanie odebrane jako brak posłuszeństwa");
            Console.WriteLine("za co zostanie ci odebrane po 10 punktów z wszystkiego ");
            Console.WriteLine("masz:");
            Thread.Sleep(900);
            Console.WriteLine($" - {zycie[0]} psychiki...");
            Thread.Sleep(900);
            Console.WriteLine($" - {zycie[1]} zdrowia...");
            Thread.Sleep(900);
            Console.WriteLine($" - {zycie[2]} energi...");
            Thread.Sleep(900);
            Console.WriteLine($" - {zycie[3]} siły...");
            return zycie;
        }


    }
}
