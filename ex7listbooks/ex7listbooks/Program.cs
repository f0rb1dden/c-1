using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7listbooks
{
    class Program
    {
        static void Main(string[] args)
        { 

          string pick = " ";
          string newbook = " ";
          string deleteee = " ";

            List<string> bookss = new List<string>() { "Please", "work", "properly", ":D" };
            do
            {
                Console.WriteLine("Here is your book collection:");
                Console.WriteLine("To add a book, press Y; To exit, press N, if you want to sort your books press S, if you want to delete a book press D");
                pick = (Console.ReadLine()).ToLower();
                if (pick == "y")
                {
                    Console.WriteLine("Add a book");
                    newbook = (Console.ReadLine().ToLower());
                    bookss.Add(newbook);
                }
                else if (pick == "d")
                {
                    Console.WriteLine("Select the book which you want to delete");
                    deleteee = (Console.ReadLine().ToLower());
                    bookss.Remove(deleteee);
                    
                }
                else if (pick == "s")
                {
                    bookss.Sort();
                }
                // LOOK THE BOTTOM

                Console.WriteLine("This is the current collection");
                foreach (string books in bookss)
                {
                    Console.WriteLine(books);
                }
             //   bookss.ForEach(Console.WriteLine); // THIS IS THE SHORTCUT OF DOING SHOWING THE BOOKS 

            } while (pick != "n");














        }//111
    }//222222
}//333333333
