using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponthatar
{
    class Program
    {
        static void Main(string[] args)
        {
            int pont = Convert.ToInt32(Console.ReadLine());          

           if(pont < 50 && pont > -1)
            {
                Console.WriteLine("egyes");
            }else if(pont < 65)
            {
                Console.WriteLine("kettes");
            }else if(pont < 80)
            {
                Console.WriteLine("hármas");
            }else if(pont < 90)
            {
                Console.WriteLine("negyes");
            }else if(pont < 101)
            {
                Console.WriteLine("ötös");
            }
            else
            {
                Console.WriteLine("hibas adat");
            }

            Console.ReadKey();
            
        }
    }
}
