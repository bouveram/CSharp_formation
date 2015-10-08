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
            Publisher editeur = new Publisher { Ca = 523698.4, Name = "Edition M2i" };

            test.Title = "ceci est le titre de mon livre";
            test.NbPage = 957;
            test.Editor = editeur;


            Console.WriteLine(test.Title);
            Console.WriteLine("Il possede a : " + test.NbPage + " pages");
            Console.WriteLine("Editor name : " + test.Editor.Name);
            Console.ReadKey();
        }
    }

}
