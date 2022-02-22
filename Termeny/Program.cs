using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termeny
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int szorzo = random.Next(5, 15);

            int termeny = Convert.ToInt32(Console.ReadLine());
            termeny *= szorzo;
            Console.WriteLine("termeny: {0}", termeny);

            if(szorzo < 9)
            {
                Console.WriteLine("atlag alatti ev");
            }else if(szorzo < 13)
            {
                Console.WriteLine("atlagos");
            }
            else
            {
                Console.WriteLine( "atlag feletti");
            }
            Console.ReadKey();
        }
    }
}
