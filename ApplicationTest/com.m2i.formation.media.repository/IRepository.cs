using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.m2i.formation.media.repository
{
    public interface IRepository<T> where T : Media
    {
        String Uri { get; set;}
        
        List<T> getAll();

        T getById(int id);

        List<T> getByPrice(double price);

        List<T> getByTitle(String word);
    }
}
