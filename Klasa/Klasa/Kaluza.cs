using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Klasa
{
    internal class Kaluza
    {

        public static int[] ZamiatanieKaluzy(int[] zycie)
        {
            Console.WriteLine("wybierz swoje narzędzie (tak, do zamiatania kałuży): \nodkurzacz - o      miotła - m       łopata - p");
            string a = Console.ReadLine();
            switch (a)
            {
                case "o":
                    return Odkurzacz(zycie);
                case "m":
                    return Miotla(zycie);
                case "p":
                    return Lopata(zycie, zycie);
                default:
                    Thread.Sleep(900);
                    Console.WriteLine("Wrzucono cię do kałuży");
                    zycie[1] -= 18;
                    Console.WriteLine($"masz {zycie[1]} zycia");
                    if (zycie[1] <= 0)
                    {
                        return zycie;
                    }
                    return ZamiatanieKaluzy(zycie);
            }
        }
     
        public static int[] Odkurzacz(int[] zycie)
        {

            Console.WriteLine("Bro wtf, dlaczego wybrałeś odkurzacz do zamiatania wody? Gdzie ty myślisz, że jesteś? W jakiejś Rosji?");
            Console.WriteLine("odstaw odkurzacz i weź coś innego  - o             podłącz odkurzacz do gniazdka - p");
            string z = Console.ReadLine();
            if (z == "o")
            {
                zycie[2] -= 1;
                return ZamiatanieKaluzy(zycie);  
            }
            else if (z == "p")
            {
                int odkurzacz = 50;
                Thread.Sleep(900);
                Console.WriteLine("Stary rosyjski odkurzacz wybuchł ci w twarz xD");
                zycie[1] -= odkurzacz;
                Thread.Sleep(900);
                Console.WriteLine($"straciłeś {odkurzacz} punktów życia...");
                return zycie;
            }
            return zycie;
        }
        public static int[] Miotla(int[] zycie)
        {
            if (zycie[4] > 0)
            {
                int starosc = 1;
                zycie[4] -= starosc;
                Thread.Sleep(900);
                Console.WriteLine("eeeeeeeeee no okej");
                Thread.Sleep(900);
                Console.WriteLine("wsiadasz na miotłę i odlatujesz do Kanady gdzie wiedziesz szczęśliwe życie z dala od tego zbrodniczego kraju");
                Thread.Sleep(2137);
                Console.WriteLine("Dziękujemy za przejście naszej gry...");
                Thread.Sleep(2137);
                return zycie;
                
            }
            else
            {
                zycie[2] -= 1;
                return ZamiatanieKaluzy(zycie);
            }
            
        }
        public static int[] Lopata(int[] zycie, int[] ty)
        {
            Console.WriteLine("zamieć wodę łopatą - z          uderz towarzysza łopatą - u");
            string z = Console.ReadLine();
            if (z == "u")
            {
                Console.WriteLine("On też ma łopatę, więc zaczynacie walkę");
                int[] towarszyszMlody = TowarzyszeWalka.MlodszyTowarzysz();
                TowarzyszeWalka.WalkaMlody(ty, towarszyszMlody);
                

                if (towarszyszMlody[1] < 0)
                {
                    Console.WriteLine("chyba zamordowałeś towarzysza... \nzakop ciało (masz łopate L) - z         Uciekaj z kraju - u ");
                    string e = Console.ReadLine();
                    if (e == "z")
                    {
                        Console.WriteLine("Zakopałeś ciało, nic się nie stało, nikt nie odkrył, że to ty. Wracasz do baraków, następnego dnia do pracy");
                        return zycie;
                    }
                    else if (e == "u")
                    {
                        Console.WriteLine("Złapali cię");
                        ty[1] -= 2000;
                        return zycie;
                    }
                }

                

            }
            else if (z == "z")
            {
                Odsniezanie.Zamiatanie(zycie, ty);
            }
            return zycie;
        }
       
    }
}
