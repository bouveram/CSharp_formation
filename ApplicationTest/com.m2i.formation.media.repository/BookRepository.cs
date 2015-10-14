using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.m2i.formation.media.repository
{
    public class BookRepository : IRepository<Book>
    {
        private String Uri {get; set; }
        
        private List<Book> cache = null;

        private List<Book> getCache() throws IOException
        {
		if(cache == null) {
                cache = cacheFactory();
            }
		return cache;
        }

        private List<Book> cacheFactory() throws IOException
        {
            // TODO Auto-generated method stub
            List<Book> bookList = new ArrayList<Book>();
            Book b = new Book();
            BufferedReader br = new BufferedReader(new FileReader(uri));
            String line;
            line = br.readLine(); //delete first Line
            line = br.readLine();
		while(line!=null) {


                b = getBookFromCSV(line);

                bookList.add(b);
                line = br.readLine();
            }
            br.close();
		return bookList;
        }

        @Override
        public List<Book> getAll()
        {
		return getCache();
        }

        @Override
        public Book getById(int id)
        {
            // TODO Auto-generated method stub
            Book bookFound = null;
		
		for(Book b:getCache()) {
                if (b.getId() == id)
                {
                    bookFound = b;
                }
            }
		return bookFound;
        }

        @Override
        public List<Book> getByPrice(double price)
        {
            // TODO Auto-generated method stub
            List<Book> bookList = new ArrayList<Book>();
		
		for(Book b:getCache()) {
                if (b.getPrice() <= price)
                    bookList.add(b);
            }
		return bookList;
        }

        @Override
        public List<Book> getByTitle(String word)
        {
            // TODO Auto-generated method stub
            List<Book> bookList = new ArrayList<Book>();
		for(Book b:getCache()){
                if (b.getTitle().matches("(?i).*" + word + ".*"))
                { //(?i) = CASE_INSENSITIVE
                    bookList.add(b);
                }
            }
		return bookList;
        }

        public Book getBookFromCSV(String line)
        {

            Book b = new Book();
            StringTokenizer st = new StringTokenizer(line, ";");
            b.setTitle = st.nextToken());
            b.setNbPage = Int32.Parse(st.nextToken()));
            b.Price = Double.Parse(st.nextToken()));
            b.setId = Int32.Parse(st.nextToken()));
            return b;
        }
    }
}
