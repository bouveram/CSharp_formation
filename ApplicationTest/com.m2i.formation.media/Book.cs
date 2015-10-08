using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.m2i.formation.media
{
    public class Book
    {
        private string title;
        public Author[] Authors { get; private set; } = new Author[10]; //Permet de creer les getter & setter. Set is private donc inaccessible
        private int nbAuthor = 0;
        /*private int id;
        private int nbPage;
        private string isbn;
        private double price;
        private string lang;
        private Publisher editor;*/

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int Id { get; set; }

        public int NbPage { get; set; }

        public string Isbn { get; set; }

        public double Price { get; set; }

        public string Lang { get; set; }

        public Publisher Editor { get; set; }

        public BookCategory Category { get; set; }

        public void AddAuthor(Author author)
        {
            this.Authors[nbAuthor] = author;
            nbAuthor++;
        }

        public void displayAuthor()
        {
            if (nbAuthor != 0)
            {
                Console.WriteLine("Contributor :");
                for (int i = 0; i < nbAuthor; i++)
                {
                    Console.WriteLine(Authors[i].FirstName + " " + Authors[i].LastName);
                }
            }
            else
            {
                Console.WriteLine("No author for now !");
            }
        }
    }
}
