using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] zycie = Postacie.KlasaPostaci();
            int dzien = 1;

            //stan psychiki, stan zdrowia, energia, siła
            int Sp = zycie[0];
            int Sz = zycie[1];  
            int En = zycie[2];  
            int Si = zycie[3];  


            Console.WriteLine("staw się do wojska - 'ok'        zignoruj - 'nie ok'");
            Console.WriteLine("                 ");

            string inp = Console.ReadLine();
            Console.WriteLine("        ");

            if (inp == "ok")
            {
                Console.WriteLine("                 ");
                while (Postacie.nieZginal(zycie))
                {
                    Informacje.informacje(zycie, dzien);

                    
                    string imp = Console.ReadLine();
                    switch (imp)
                    {
                        case "1":
                            Console.WriteLine("                 ");
                            Trawa.MalowanieTrawy(zycie, Sp, Sz, En, Si);
                            break;
                        case "2":
                            Console.WriteLine("                 ");
                            Snieg.walka(zycie, zycie);
                            break;
                        case "3":
                            Console.WriteLine("                 ");
                            Console.WriteLine("zamiatanie kałuż");
                            break;
                        case "4":
                            Console.WriteLine("                 ");
                            Console.WriteLine("malowanie kół pastą do butów");
                            break;
                        case "5":
                            Console.WriteLine("                 ");
                            Console.WriteLine("dłuższe spanko");
                            break;
                            default:
                            Console.WriteLine("                 ");
                            Console.WriteLine("musisz coś wybrać");
                            break;
                    }
                    dzien += 1;

                }
                
            }

            else if (inp == "nie ok")
            {
                Console.WriteLine("        ");
                Console.WriteLine(
                    "Jeżeli ty nie przychodzisz do wojska, \n" +
                    "to wojsko przychodzi do ciebie. Zostajesz wysłany do koloni karnej na 10 lat, \n" +
                    "gdzie umierasz z wycieńczenia :)\n" +
                    "Dziękuję za grę...");
            }

            Console.ReadKey();
        
        }
    }
}
