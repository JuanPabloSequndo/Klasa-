using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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
            int x = zycie[5];   

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
                            Kaluza.ZamiatanieKaluzy(zycie);
                            break;
                        default:
                            Console.WriteLine("                 ");
                            Console.WriteLine("musisz coś wybrać");
                            MusiszCosWybrac.Wybierz(zycie);
                            break;
                    }
                    dzien += 20;

                    if (dzien > 183 && dzien < 365)
                    {
                        Thread.Sleep(350);
                        Console.WriteLine("dotrwałeś do połowy roku.");
                        Thread.Sleep(350);
                        Console.WriteLine("Gratulacje");
                        Thread.Sleep(350);
                        Console.WriteLine("Awansujesz na starszego towarzysza. Możesz teraz bić młodszych prawem silniejszego");
                        zycie[0] += 20;
                        zycie[1] += 20;
                        zycie[2] += 20;
                        zycie[3] += 20;
                        Thread.Sleep(350);
                        Console.WriteLine("+ 20 psychiki, + 20 zdrowia, + 20 energi, + 20 siły");
                    }

                    else if (dzien > 365)
                    {
                        Console.WriteLine("      ");
                        Thread.Sleep(350);
                        Console.WriteLine("NASZE gratulacje. Przetrwałeś ten rok! Możesz teraz iść do domu.");
                        Thread.Sleep(350);
                        Console.WriteLine("Będziemy za tobą tęsknić");
                        Console.WriteLine("      ");

                        Thread.Sleep(2137);
                        Console.WriteLine("Masz nową wiadmość od:");
                        Thread.Sleep(900);
                        Console.WriteLine("Związek Radziecki");
                        Thread.Sleep(1400);
                        Console.WriteLine("Temat:...");
                        Thread.Sleep(900);
                        Console.WriteLine("Zdrastfujcie towarzyszu");
                        Thread.Sleep(350);
                        Console.WriteLine("Każdemu byłemu kadetowi oferujemy darmowe mieszkanie,");
                        Thread.Sleep(350);
                        Console.WriteLine("bezpłatną opiekę medyczną wysokiej jakości, wsparcie finansowe,");
                        Thread.Sleep(350);
                        Console.WriteLine("i anulowanie wszystkich twoich długów (bo możemy, czemu nie?)");
                        Thread.Sleep(350);
                        Console.WriteLine("ale... um mamy jeden warunek UwU");
                        Thread.Sleep(1500);
                        Console.WriteLine("Jeżeli będziemy potrzebowć cię gdzieś na froncie, na przykład ummm... na Ukrainie");
                        Console.WriteLine("to masz sie stawić. Inaczej kolonia karna :)");
                        Console.WriteLine("Decyduj");
                        Console.WriteLine("      ");
                        Thread.Sleep(900);
                        Console.WriteLine("zgadzaj się - tak      nie zgadzaj się - nie ");
                        Console.WriteLine("      ");

                        string a = Console.ReadLine();
                        switch (a)
                        {
                            case "tak":
                                TakNie.Tak(zycie);
                                break;
                            case "nie":
                                TakNie.Nie(zycie);
                                break;
                        }

                    }

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
