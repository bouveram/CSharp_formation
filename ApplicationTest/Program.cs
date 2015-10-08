using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Book test = new Book();

            test.Title = "ceci est le titre de mon livre";

            Console.WriteLine(test.Title);
            Console.ReadKey();
        }
    }

}
