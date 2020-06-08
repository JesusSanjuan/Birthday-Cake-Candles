using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Cake_Candles
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] ar = new long[10] {5,5,5,3,8,8,6,6,9,5 };
            int result = birthdayCakeCandles(ar);

            Console.Read();
        }


        static int birthdayCakeCandles(long[] ar)
        {
            List<long> lst = ar.OfType<long>().ToList();
            var agrupacion = lst.GroupBy(x => x).Select(g => new { Text = g.Key, Count = g.Count() }).ToList();
            var masvelaalta = lst.Max();
            int cantidadvelas = 0;
            foreach (var el in agrupacion)
            {
                if (el.Text == masvelaalta)
                {
                     cantidadvelas = el.Count;
                    break;
                }                
            }
            return cantidadvelas;
        }



    }
}
