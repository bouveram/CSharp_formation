using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.m2i.formation.media
{
    public class Book : Media
    {
        
        public BookCategory Category { get; set; }
        
        public string Isbn { get; set; }

        public int NbPage { get; set; }
        
    }
}
