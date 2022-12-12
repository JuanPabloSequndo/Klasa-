using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa
{
    internal class Odsniezanie
    {

        public static int[] Obiad()
        {
            int[] ObiadEnergia = new int[4];
            ObiadEnergia[2] = 4;
            return ObiadEnergia;
        }

        public static int[] SNieg()
        {
            Random rnd = new Random();
            int[] SniegEnergia = new int[4];

            SniegEnergia[2] = rnd.Next(2, 6);
            return SniegEnergia;

        }

        public static int[] Woda()
        {
            Random rnd = new Random();
            int[] WodaEnergia = new int[4];

            WodaEnergia[2] = rnd.Next(2, 6);
            return WodaEnergia;

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int[] ODsniezanie(int[] zycie, int[] ty)
        {

            Console.WriteLine("   ");
            Console.WriteLine("odśnierz 10 m2 (kosztuje cię to od 2 do 6 punktów energi, \n" +
                    "ale za każde 10 m2 dostaniesz potem 4 punkty energi w postaci obiadu)");
            Console.WriteLine("   ");

            int[] Snieg = SNieg();
            int[] ObiadEnergia = Obiad();
            int metry = 1;

            Console.WriteLine("koś - d     przestań kosić - e ");
            Console.WriteLine("   ");

            while (ty[2] > -1)
            {
                string b = Console.ReadLine();
                if (b == "d")
                {
                    ty[2] -= Snieg[2];
                    Console.WriteLine($"wykorzystałeś {Snieg[2]} energi, masz {ty[2]} punktów energii");

                }
                else if (b == "e")
                {
                    zycie[2] = metry * ObiadEnergia[2];
                    Console.WriteLine($"Obiadek po pracy dodał ci {zycie[2]} energii. Potem poszedłeś spać... nowy dzień...");
                    Console.WriteLine("    ");
                    return ty;
                }
                else
                {
                    Console.WriteLine("za nie wykonywanie roboty, zostajesz zamknięty w chłodni");
                    ty[1] -= 30;
                    return ty;
                }

                metry += 1;
            }
                return ty;    
        }

        public static int[] Zamiatanie(int[] zycie, int[] ty)
        {

            Console.WriteLine("   ");
            Console.WriteLine("zamieć 1l wody (kosztuje cię to od 2 do 6 punktów energi, \n" +
                    "ale za każdy litr dostaniesz potem 4 punkty energi w postaci obiadu)");
            Console.WriteLine("   ");

            int[] woda = Woda();
            int[] ObiadEnergia = Obiad();
            int metry = 1;

            Console.WriteLine("zamiataj - d     przestań zamiatać - e ");
            Console.WriteLine("   ");

            while (ty[2] > -1)
            {
                string b = Console.ReadLine();
                if (b == "d")
                {
                    ty[2] -= woda[2];
                    Console.WriteLine($"wykorzystałeś {woda[2]} energi, masz {ty[2]} punktów energii");

                }
                else if (b == "e")
                {
                    zycie[2] = metry * ObiadEnergia[2];
                    Console.WriteLine($"Obiadek po pracy dodał ci {zycie[2]} energii. Potem poszedłeś spać... nowy dzień...");
                    Console.WriteLine("    ");
                    return ty;
                }
                else
                {
                    Console.WriteLine("za nie wykonywanie roboty, zostajesz zamknięty w chłodni");
                    ty[1] -= 30;
                    return ty;
                }

                metry += 1;
            }
            return ty;
        }
    }
}
