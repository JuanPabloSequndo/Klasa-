using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Klasa
{
    internal class Snieg
    {   

        //nasi przeciwnicy Młody Tow; Snieg; 
        public static int[] MlodszyTowarzysz()
        {
            Random random = new Random();
            int[] towarzyszZycie = new int[4];
            
            towarzyszZycie[1] = random.Next(14, 50);          
            towarzyszZycie[3] = random.Next(5, 12);
            towarzyszZycie[2] = random.Next(2, 4);
            return towarzyszZycie;
            

        }

        public static int[] SNieg()
        {
            Random rnd = new Random();
            int[] SniegEnergia = new int[4];

            SniegEnergia[2] = rnd.Next(2, 5);
            return SniegEnergia;

        }

        //nasz przyjaciel obiadek
        public static int[] Obiad()
        {
            int[] ObiadEnergia = new int[4];
            ObiadEnergia[2] = 4;
            return ObiadEnergia;    
        }

        //akcja
        public static int[] walka(int[] zycie, int[] ty)
        {
            Console.WriteLine("Zaatakuj młodszego towarzysza - 1      zrób swoją robotę - 2");
            Console.WriteLine("           ");
            string inp = Console.ReadLine();
            if (inp == "1")
            {
                Console.WriteLine("      ");
                Console.WriteLine("Rozpoczynasz walkę na śnieszki z młodszym towarzyszem:");
                Console.WriteLine("       ");
                int[] towarzysz = MlodszyTowarzysz();

                while (towarzysz[1] > 0)
                {
                    ty[1] -= towarzysz[3];
                    towarzysz[1] -= ty[3];
                    ty[2] -= towarzysz[2];

                    Thread.Sleep(900);
                    Console.WriteLine($"masz {ty[1]} zdrowia, obrywasz {towarzysz[3]}, " +
                        $"towarszysz ma {towarzysz[1]} zdrowia, obrywa {ty[3]}, zostało ci {ty[2]} energii");

                    if (ty[1] <= 0)
                    {
                        Console.WriteLine("       ");
                        Console.WriteLine("przegrałeś z towarzyszem, więc straciłeś mnóstwo siły \n" +
                                          "i zmarłeś z wycieńczenia");
                        Console.WriteLine("        ");
                        break;

                    }
                }

                if (towarzysz[1] < 0)
                {
                    Console.WriteLine("       ");
                    Console.WriteLine("Jesteś zwycięscą, twój towarzysz zmarł w ciepieniach.\n" +
                        "Dostajesz +4 do siły i +14 do samopoczucia, ale nadal musisz skosić śnieg.");
                    Console.WriteLine("        ");
                    zycie[0] += 14;     
                    zycie[3] += 4;

                    Console.WriteLine("skoś ten śnieg - ok         opierniczaj się - nie ok");
                    Console.WriteLine("        ");
                    string a = Console.ReadLine();
                    if (a == "nie ok")
                    {
                        Console.WriteLine("podchodzi do ciebie starszy towarzysz i...");
                        while (ty[1] > 0)
                        {
                            Random eee = new Random();
                            int[] cios1 = new int[4];
                            cios1[1] = eee.Next(1, 4);  
                            zycie[1] -= cios1[1];
                            Thread.Sleep(900);
                            Console.WriteLine($"...zadał ci {cios1[1]}. Zostało ci {zycie[1]} zdrowia...");
                        }
                        
                    }

                    else if (a == "ok")
                    {
                        if (ty[2] > 5)
                        {
                            Console.WriteLine("   ");
                            Console.WriteLine("odśnierz 1 m^2 (kosztuje cię to od 2 do 5 punktów energi, \n" +
                                    "ale za każdy m2 dostaniesz potem 3 punkty energi w postaci obiadu) NACIŚNIJ SPACJĘ");
                            Console.WriteLine("   ");

                            int[] Snieg = SNieg();
                            int[] ObiadEnergia = Obiad();
                            int metry = 1;

                            Console.WriteLine("koś - d     przestań kosić - e ");
                            Console.WriteLine("   ");
                            string d = Console.ReadLine();
                            if (d == " ")     
                            {
                                while (ty[2] > -1)
                                {
                                    string b = Console.ReadLine();
                                    if (b == "d")
                                    {
                                        ty[2] -= Snieg[2];
                                        Console.WriteLine($"wykorzystałeś {Snieg[2]} energi, masz {ty[2]} punktów energii");
                                        
                                    }
                                    else if (d == "e")
                                    {
                                        zycie[2] = metry * ObiadEnergia[2];
                                        Console.WriteLine($"Obiadek po pracy dodał ci {zycie[2]} energii. Potem poszedłeś spać... nowy dzień...");
                                        Console.WriteLine("    ");
                                        return ty;
                                    }
                                    metry += 1;
                                }       
                            }  
                        }
                        else if (ty[2] <= 4)
                        {
                            Console.WriteLine("nie ma wystarczjąco energii, prawdopodobnie wykorzystałeś ją całą do walki...");
                        }
                    }
                }
            }

            else if (inp == "2")
            {

                Console.WriteLine("   ");
                Console.WriteLine("odśnierz 1 m2 (kosztuje cię to od 2 do 5 punktów energi, \n" +
                        "ale za każdy m2 dostaniesz potem 3 punkty energi w postaci obiadu)");
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
                        Thread.Sleep(900);

                    }
                    else if (b == "e")
                    {
                        zycie[2] = metry * ObiadEnergia[2];
                        Console.WriteLine($"Obiadek po pracy dodał ci {zycie[2]} energii. Potem poszedłeś spać... nowy dzień...");
                        Console.WriteLine("    ");
                        return ty;
                    }
                    metry += 1;
                }

            }
                return ty;
            


        }

    }
}
