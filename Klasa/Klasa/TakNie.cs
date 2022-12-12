using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Klasa
{
    internal class TakNie
    {

        public static void Tak(int[] zycie)
        {
            Console.WriteLine("    ");
            Console.WriteLine("Dostajesz wszystko co zostało ci obiecane, ale 24 lutego 2022 roku zostajesz zaangarzowany \n" +
                "w wojnę na Ukrainie gdzie w listopadzie giniesz podczas akcji odbijania Chersonia.");
            zycie[1] -= 500;
        }

        public static void Nie(int[] zycie)
        {
            if (zycie[5] == 1) 
            {
                Console.WriteLine("    ");
                Console.WriteLine("Wróciłeś do swojego miasteczka klepiąc biedę, twoja sytuacja pogarszała się z dnia na dzień \n" +
                    "i w końcu nie stać cię było nawet na jedzenie. Sprzedałeś dom i wylądowałeś pod mostem gdzie ");
                zycie[1] -= 500;
            }

            else if (zycie[5] == 2)
            {
                Console.WriteLine("    ");
                Console.WriteLine("Wróciłeś do Moskwy. Nie masz najlepszego życia, inflacja rośnie, zamknięto granice a ty czujesz\n" +
                    "beznadzieję sytuacji wzrastającą każdego dnia. Pozytyw jest taki, że przetrwałeś szkolenie wojskowe i dzięki\n" +
                    "stabilnej sytuacji finansowej nadal żyjesz. ");
                zycie[0] += 1001;
            }
        }


    }
}
