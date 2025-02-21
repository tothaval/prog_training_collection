using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeViewTraining.Models;


namespace TreeViewTraining.Services
{
    public class BookService : IBookService
    {
        const string DEV_CAT = "Software Development";
        const string FANTASY_CAT = "Fantasy";


        public static List<Book> books = new List<Book>()
        {
            new Book("Stephan Kammel", "Die Ankunft des Vorboten", FANTASY_CAT, new int[]{1,2,3,4,5 }),
            new Book("Stephan Kammel", "Kyal Sur", FANTASY_CAT, new int[]{4,5 }),
            new Book("Bernhard Wurm", "Schrödinger programmiert C#", DEV_CAT, new int[]{1,2,3,4,5 }),
            new Book("John R Tolkien", "Der Herr der Ringe", FANTASY_CAT, new int[]{1,2,3,4,5 ,5,3,4}),
            new Book("Frank Schätzing", "Limit", FANTASY_CAT, new int[]{1,2,3,5,3,4 }),
            new Book("Wolfgang & Heike Hohlbein", "Drachenfeuer", FANTASY_CAT, new int[]{1, 5, 3, 4, 3,4,5 }),
            new Book("Andrew Hunt", "Programmieren Lernen!", DEV_CAT, new int[]{4,5,4,4,4,4,5,5,3,4 })
        };

        public IEnumerable<Book> GetBooks() => books;
    }
}
