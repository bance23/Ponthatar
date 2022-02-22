using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hianyzas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hány hiányzása van?");
            int hianyzas = Convert.ToInt32(Console.ReadLine());

            if (hianyzas > 9)
            {
                Console.WriteLine("Add meg a születési dátumod:");
                string szuldat = Console.ReadLine();
                Console.WriteLine("Ekkor született:{0}", szuldat, "és ennyit hiányzott:{0}", hianyzas);
            }
            if (9 < hianyzas & hianyzas < 16)
            {
                Console.WriteLine("Figyelmeztetés");
            }
            else if (15 < hianyzas & hianyzas < 20)
            {
                Console.WriteLine("Osztályfőnöki megrovó");
            }
            else if (19 < hianyzas & hianyzas < 30)
            {
                Console.WriteLine("Igazgatói megrovó");
            }
            else
            {
                Console.WriteLine("Fegyelmi");
            }
            Console.ReadKey();
        }
    }
}
