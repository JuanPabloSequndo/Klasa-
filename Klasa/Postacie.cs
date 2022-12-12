using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

                Console.WriteLine("                     ");
                Console.WriteLine("Biedny Rosjanin - 1, Nie biedny Rosjanin - 2");
                Console.WriteLine("                ");

                string inp = Console.ReadLine();    

                if (inp == "1")
                {
                    int[] z = { 20, 45, 26, 10};
                    Console.WriteLine("                ");
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    Console.WriteLine("                ");
                    Console.WriteLine(
                        "Pewnego razu przyszedł do ciebie list z urzędu, że masz się stawić do wojska :) Co robisz?");
                    Console.WriteLine("                        ");
                    return z;


                }
                else if (inp == "2")
                {
                    int[] y = { 40, 50, 10, 6 };

                    Console.WriteLine("                ");
                    Console.WriteLine(
                        "Pewnego razu przyszedł do ciebie list z urzędu, że masz się stawić do wojska :) Co robisz?");
                    Console.WriteLine("                ");
                    Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
                    Console.WriteLine("                ");
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
            if (zycie[0] <= 0)
            {
                Console.WriteLine("Umierasz... Dziękujemy za grę :)");
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
            else
                return true;    
        }

    }
}