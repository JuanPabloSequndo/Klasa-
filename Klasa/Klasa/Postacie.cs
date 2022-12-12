using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Klasa
{
    internal class Postacie
    {

        public static int[] KlasaPostaci()
        {
            //siła psychiki, stan zdrowia, energia, siła
            while(true)
            {
                Console.WriteLine("             ");
                Console.WriteLine(
            "  ____________________________________________                _________________________________________________ \n"  +
            " | Pov: jesteś biendym Ruskiem z przeciętnego |              | Pov: jesteś nie biednym Ruskiem żyjącym         |\n" +
            " | małego miasta na północ od Moskwy.         |              | w centrum Moskwy. Zarabiasz ok. 30 tysięcy      |\n" +
            " | zarabiasz ok. 30 tysięcy rubli na          |              | na stanowisku programisty (czyli mniej, więcej  |\n" +
            " | stanowisku kelnera (to będzie mniej        |              | 4400 zł miesięcznie) i w miarę dobrze sobie     |\n" +
            " | więcej 2200 złotych mięsiecznie)           |              | radzisz. Bez problemu opłacasz czynsz, stać     |\n" +
            " | i ledwo dajesz radę płacić czynsz,         |              | cię na ubrania i wszystkie najpotrzebniejsze    |\n" +
            " | nie stac cię na nowe ubrania, więc         |              | rzeczy. Czasem możesz nawet zabrac rodzię do    |\n" +
            " | chodzisz w starych i zniszczonych a na     |              | restauracji. Jesteś w świetnej kondycji         |\n" +
            " | jedzenie musisz sobie dorabiać montując    |              | zdrowotnej i towarzyszy ci dobre samopoczucie.  |\n" +
            " | filmy dla influenserów. W twoim domu       |              | Brakuje ci jednak odwagi i masz dość            |\n" +
            " | brakuje najbardziej podstawowych rzeczy    |              | słabą psychikę                                  |\n" +
            " | jak pralka czy lodówka. Trudna sytuacja    |              |                                                 |\n" +
            " | życiowa sprawiła, że masz dość silną       |              |                                                 |\n" +
            " | psychikę i jesteś w stanie wiele przetrwać |              |                                                 |\n" +
            " ---------------------------------------------                ------------------------------------------------- \n"); 

                Console.WriteLine("                     ");
                Console.WriteLine("Wybierz swoją postać:");
                Console.WriteLine("Biedny Rosjanin - 1, Nie biedny Rosjanin - 2");

                string inp = Console.ReadLine();    

                if (inp == "1")
                {
                    int[] z = { 20, 50, 26, 20, 101, 1};
                    Console.WriteLine("------------------------------------------------------------------------------------------");
                    Console.WriteLine("Pewnego razu przyszedł do ciebie list z urzędu, że masz się stawić do wojska :) Co robisz?");
                    return z;

                    
             
                }
                else if (inp == "2")
                {
                    int[] y = { 40, 25, 10, 10, 101, 2};
                    Console.WriteLine("------------------------------------------------------------------------------------------");
                    Console.WriteLine("Pewnego razu przyszedł do ciebie list z urzędu, że masz się stawić do wojska :) Co robisz?");
                    return y;

                }
                else
                {
                    Console.WriteLine("Masz do wyboru tylko 2 opcje");
                }
            }
        }

        public static bool nieZginal(int[] zycie)
        {
            if (zycie[0] >= 1000)
            {
                Console.WriteLine("Gratulujemy za przejście NASZEJ gry. Miłego dnia :)");
                return false;
            }
            else if (zycie[1] <= 0)
            {
                Console.WriteLine("Umierasz... Dziękujemy za grę :)");
                return false;
            }
            else if (zycie[2] <= 0)
            {
                Console.WriteLine("Umierasz... Dziękujemy za grę :)");
                return false;
            }
            else if (zycie[3] <= 0)
            {
                Console.WriteLine("Umierasz... Dziękujemy za grę :)");
                return false;
            }
            else if (zycie[4] <= 100)
            {
                Console.WriteLine("    ");
                Thread.Sleep(1600);
                Console.WriteLine("Masz nową wiadomość od:");
                Thread.Sleep(1600);
                Console.WriteLine("Związek Radziecki");
                Thread.Sleep(1600);
                Console.WriteLine("Temat: ...");
                Thread.Sleep(2000);
                Console.WriteLine("I co? Myślałeś, że będzie tak łatwo? Nasi ludzie już cię namierzyli...");
                Thread.Sleep(2137);
                Console.WriteLine("Możesz juz się żegnac z bliskimi.");
                Thread.Sleep(2137);

                while (zycie[4] > 0)
                {

                    int x = 1;
                    Thread.Sleep(3);
                    while (x == 1)
                    {
                        Console.WriteLine("                                                        ");
                        x++;
                    }
                    Thread.Sleep(3);
                    while (x == 2)
                    {
                        Console.WriteLine("      |\\**/|               |\\**/|                     ");
                        x++;
                    }
                    Thread.Sleep(3);
                    while (x == 3)
                    {
                        Console.WriteLine("      \\ == /     |\\**/|    \\ == /      |\\**/|       ");
                        x++;
                    }
                    Thread.Sleep(3);
                    while (x == 4)
                    {
                        Console.WriteLine("       |  |      \\ == /     |  |       \\ == /         ");
                        x++;
                    }
                    Thread.Sleep(3);
                    while (x == 5)
                    {
                        Console.WriteLine("       |  |       |  |      |  |        |  |            ");
                        x++;
                    }
                    Thread.Sleep(3);
                    while (x == 6)
                    {
                        Console.WriteLine("       \\  /       |  |      \\  /        |  |          ");
                        x++;
                    }
                    Thread.Sleep(3);
                    while (x == 7)
                    {
                        Console.WriteLine("        \\/        \\  /       \\/         \\  /        ");
                        x++;
                    }
                    Thread.Sleep(3);
                    while (x == 8)
                    {
                        Console.WriteLine("                   \\/                    \\/           ");
                        x++;
                    }
                    Thread.Sleep(3);
                    while (x == 9)
                    {
                        Console.WriteLine("                                                        ");
                        x++;
                    }
                    Thread.Sleep(3);
                    while (x == 10)
                    {
                        Console.WriteLine(" |\\**/|               |\\**/|                          ");
                        x++;
                    }
                    Thread.Sleep(3);
                    while (x == 11)
                    {
                        Console.WriteLine(" \\ == /     |\\**/|    \\ == /      |\\**/|            ");
                        x++;
                    }
                    Thread.Sleep(3);
                    while (x == 12)
                    {
                        Console.WriteLine("  |  |      \\ == /     |  |       \\ == /              ");
                        x++;
                    }
                    Thread.Sleep(3);
                    while (x == 13)
                    {
                        Console.WriteLine("  |  |       |  |      |  |        |  |                 ");
                        x++;
                    }
                    Thread.Sleep(3);
                    while (x == 14)
                    {
                        Console.WriteLine("  \\  /       |  |      \\  /        |  |               ");
                        x++;
                    }
                    Thread.Sleep(3);
                    while (x == 15)
                    {
                        Console.WriteLine("   \\/        \\  /       \\/         \\  /             ");
                        x++;
                    }
                    Thread.Sleep(3);
                    while (x == 16)
                    {
                        Console.WriteLine("              \\/                    \\/                ");
                        x++;
                    }
                    zycie[4] -= 3;
                }
                return false;
            }
            else
                return true;    
        }

    }
}