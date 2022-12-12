using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Klasa
{
    internal class Trawa
    {
        public static int[] MalowanieTrawy(int[] zycie, int Sp, int Sz, int En, int Si)
        {
            Console.WriteLine("'1' - pomaluj starszego towarzysza na zielono        '2' - przyłóż sie do pracy");
            Console.WriteLine("       ");
            string imp = Console.ReadLine();
            switch (imp)
            {
                case "1":
                    return Beat(zycie, Sp, Sz, En, Si);
                case "2":
                    return NotBeat(zycie, Sp, Sz, En, Si);
                default:
                    return zycie;
            }
        }        
        public static int[] Beat(int[] zycie, int Sp, int Sz, int En, int Si)
        {
            zycie[0] -= 10;
            zycie[1] -= 30;
            zycie[2] -= 5;
            zycie[3] -= 2;
            Console.WriteLine("Starszy towarzysz zwołał kolegów i zbili cię na miazgę");
            return zycie;
        }
        public static int[] NotBeat(int[] zycie, int Sp, int Sz, int En, int Si)
        {
            zycie[0] -= 0;
            zycie[1] += 10;
            zycie[2] -= 5;
            zycie[3] += 3;
            Console.WriteLine("zmęczyłeś się podczas pracy - 5 p, ale dostajesz + 10 zdrowia i +3 siły");
            return zycie;
        }
        
        

        
    }
}
