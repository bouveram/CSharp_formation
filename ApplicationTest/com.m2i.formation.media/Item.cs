using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.m2i.formation.media
{
    public abstract class Item : IItem
    {
        public int Id { get; set; }

        public double Price { get; set; }

        public string Name { get; set; }
    }
}
