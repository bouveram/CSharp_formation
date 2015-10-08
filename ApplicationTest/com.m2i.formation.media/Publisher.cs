using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.m2i.formation.media
{
    public class Publisher
    {

        public string Name { get; set; }
        public string SiretNb { get; set; }
        public double Ca { get; set; }

        /*
	     * Affiche des infos spécifiques lors du debugage
	     */
        new public String ToString()
        {
            return "Editor " + Name;
        }

    }
}
