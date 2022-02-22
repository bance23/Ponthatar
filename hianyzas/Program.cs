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
            int hianyzas = Convert.ToInt32(Console.ReadLine());

            if (hianyzas > 10)
            {
                Console.WriteLine("Add meg a születési dátumod:");
                string szuldat = Console.ReadLine();
                Console.WriteLine("Ekkor született:{0}", szuldat, "és ennyit hiányzott:{0}", hianyzas);
            }
        }
    }
}
