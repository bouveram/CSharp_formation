using com.m2i.formation.media;
using com.m2i.formation.geometry;
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
            Book livre2 = new Book();
            Publisher editeur = new Publisher { Ca = 523698.4, Name = "Edition M2i" };

            Author guillaume = new Author { FirstName = "Guillaume", LastName = "Tel" };
            Author arthur = new Author { FirstName = "Arthur", LastName = "Le Roi" };
            Author maurice = new Author { FirstName = "Maurice", LastName = "Momo" };

            test.Title = "ceci est le titre de mon livre";
            test.NbPage = 957;
            test.Editor = editeur;
            test.displayAuthor();
            test.AddAuthor(guillaume);
            test.AddAuthor(arthur);
            
            livre2.AddAuthor(maurice);

            Console.WriteLine(test.Title);
            Console.WriteLine("Il possede a : " + test.NbPage + " pages");
            Console.WriteLine("Editor name : " + test.Editor.Name);
            test.displayAuthor();
            Console.ReadKey();

            Console.WriteLine( Counter.increment() );
            Console.WriteLine( Counter.increment() );
            Console.ReadKey();

            test.Category = BookCategory.Poem;
            Console.WriteLine(test.Category );
            Console.ReadKey();

            Point3D p3d = new Point3D();
            p3d.X = 5;
            p3d.Z = 9;
        }
    }

}
