using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.m2i.formation.media
{
    public class Dvd : Media
    {
        public int NbCapitre { get; set; }

        public override double VATPrice
        {
            get { return Price * 1.2; }

        }
    }
}
