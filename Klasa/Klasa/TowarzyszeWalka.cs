using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Klasa
{
    internal class TowarzyszeWalka
    {

        public static int[] MlodszyTowarzysz()
        {
            Random random = new Random();
            int[] towarzyszZycie = new int[4];

            towarzyszZycie[1] = random.Next(15, 30);
            towarzyszZycie[3] = random.Next(5, 12);
            towarzyszZycie[2] = random.Next(2, 4);
            return towarzyszZycie;
        }

        public static int[] StarszyTowarzysz()
        {
            Random random = new Random();
            int[] TowarzyszZycie = new int[4];

            TowarzyszZycie[1] = random.Next(30, 55);
            TowarzyszZycie[3] = random.Next(5, 15);
            TowarzyszZycie[2] = random.Next(2, 4);
            return TowarzyszZycie;
        }




        /////////////////////////////////////////////////////////////////////////
        public static void WalkaMlody(int[]ty, int[]towarzysz)
        {

            while (ty[1] <= 0)
            {
                Console.WriteLine("przegrałeś z towarzyszem, więc straciłeś mnóstwo siły \n" +
                                  "i zmarłeś z wycieńczenia");
                break;
            }

            while (towarzysz[1] > 0)
            {
                ty[1] -= towarzysz[3];
                towarzysz[1] -= ty[3];
                ty[2] -= towarzysz[2];
            }

            Thread.Sleep(900);
            Console.WriteLine($"masz {ty[1]} zdrowia, obrywasz {towarzysz[3]}, " +
                $"towarszysz ma {towarzysz[1]} zdrowia, obrywa {ty[3]}, zostało ci {ty[2]} energii");

            
            //return towarzysz;
        }




        /////////////////////////////////////////////////////////////////////////
        public static void WalkaStarszy(int[]ty, int[]towarzyszStarszy)
        {
            ty[1] -= towarzyszStarszy[3];
            towarzyszStarszy[1] -= ty[1];

            Thread.Sleep(900);
            Console.WriteLine($"...zadał ci {towarzyszStarszy[3]}. Zostało ci {ty[1]} zdrowia...");
        }





    }
}
