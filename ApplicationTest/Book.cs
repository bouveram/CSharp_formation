using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTest
{
    public class Book
    {
        private string title;
        private int id;
        private int nbPage;
        private string isbn;
        private double price;
        private string lang;

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
    }
}
