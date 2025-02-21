using TreeViewTraining.Models;

namespace TreeViewTraining.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
    }
}