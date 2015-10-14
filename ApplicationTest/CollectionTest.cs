using com.m2i.formation.media;
using com.m2i.formation.geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTest
{
    class CollectionTest
    {
        public IList<Book> listTest()
        {

            IList<Book> liste = new List<Book>();
            Book b1 = new Book();
            Book b2 = new Book();
            Book b3 = new Book();
            Book b4 = new Book();

            b1.Name = "Premier Livre";
            b2.Name = "Deuxieme Livre";
            b3.Name = "Troisieme Livre";
            b4.Name = "Quatrieme Livre";

            liste.Add(b1);
            liste.Add(b2);
            liste.Add(b3);
            liste.Insert(1, b4);

            liste.RemoveAt(2);

            return liste;
        }

        public ISet<Book> setTest()
        {
            ISet<Book> set = new HashSet<Book>();
            Book b1 = new Book();
            Book b2 = new Book();
            Book b3 = new Book();
            Book b4 = new Book();

            b1.Name = ("Premier Livre");
            b2.Name = ("Deuxieme Livre");
            b3.Name = ("Troisieme Livre");
            b4.Name = ("Quatrieme Livre");

            set.Add(b1);
            set.Add(b2);
            set.Add(b3);
            set.Add(b1);

            set.Remove(b2);

            return set;
        }

        public IDictionary<String, Book> mapTest()
        {
            IDictionary<String, Book> map = new Dictionary<String, Book>();
            Book b1 = new Book();
            Book b2 = new Book();
            Book b3 = new Book();
            Book b4 = new Book();

            b1.Name = ("Premier Livre");
            b2.Name = ("Deuxieme Livre");
            b3.Name = ("Troisieme Livre");
            b4.Name = ("Quatrieme Livre");

            map.Add("one", b1);
            map.Add("two", b2);
            map.Add("three", b3);
            map.Add("four", b1);
            
            map.Remove("four");

            return map;
        }
    }
}
