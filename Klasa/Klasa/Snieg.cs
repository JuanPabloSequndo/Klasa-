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
       

        //akcja
        public static int[] walka(int[] zycie, int[] ty)
        {
            Console.WriteLine("Zaatakuj młodszego towarzysza - 1      zrób swoją robotę - 2");
            string inp = Console.ReadLine();
            if (inp == "1")
            {
                Console.WriteLine("Rozpoczynasz walkę na śnieszki z młodszym towarzyszem:");
                int[] towarszyszMlody = TowarzyszeWalka.MlodszyTowarzysz();
                TowarzyszeWalka.WalkaMlody(ty, towarszyszMlody);

                if (towarszyszMlody[1] < 0)
                {
                    Console.WriteLine("Jesteś zwycięscą, twój towarzysz zmarł w ciepieniach.\n" +
                        "Dostajesz +4 do siły i +14 do samopoczucia, ale nadal musisz skosić śnieg.");
                    zycie[0] += 14;     
                    zycie[3] += 4;

                    Console.WriteLine("skoś ten śnieg - ok         opierniczaj się - nie ok");
                    string a = Console.ReadLine();
                    
                    switch (a)
                    {
                        case "nie ok":
                            Console.WriteLine("podchodzi do ciebie starszy towarzysz i...");
                            int[] towarzyszStary = TowarzyszeWalka.StarszyTowarzysz();

                            while (ty[1] > 14)
                            {
                                TowarzyszeWalka.WalkaStarszy(ty,towarzyszStary);
                                
                            }

                            Console.WriteLine("Nadal masz zamiar sie opierniczać?   tak/nie");
                            string w = Console.ReadLine();
                            if (w == "tak")
                            {
                                while (ty[1] > -1)
                                {   
                                    TowarzyszeWalka.WalkaStarszy(ty, towarzyszStary);  
                                }
                            }
                            else if (w == "nie")
                            {
                                Odsniezanie.ODsniezanie(zycie, ty);
                            }
                                return ty;
                            

                        case "ok":
                            if (ty[2] > 5)
                            {
                                Odsniezanie.ODsniezanie(zycie, ty);
                            }


                            else if (ty[2] <= 4)
                            {
                                Console.WriteLine("nie ma wystarczjąco energii, prawdopodobnie wykorzystałeś ją całą do walki...");
                            }
                            return ty; ;
                    }
                }
            }

            else if (inp == "2")
            {
                Odsniezanie.ODsniezanie(zycie, ty);
            }
         return ty;
        }
    }
}
