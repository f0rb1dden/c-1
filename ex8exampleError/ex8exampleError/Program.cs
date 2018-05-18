using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex8exampleError
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = null;
            try
            {
                sr = File.OpenText(@"C:\Users\student\Desktop\DONT_TOUCH_ME\c####\ex8exampleError\ddd.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("and the program continues ...");







        }
    }
}
