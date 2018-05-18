using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ex8errors
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3 };
            int ss = 0;

            try
            {
                for (int i = 0; i < 18; i++)
                {
                    ss = numbers[i];
                }
               
            }
            catch(IndexOutOfRangeException kljkl)
            {
                Console.WriteLine("ddddddd");

            }


            Console.WriteLine("Its still working");




        }
    }
}
