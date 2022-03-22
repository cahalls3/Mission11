using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mission11.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }

        public void SaveBook(Book b);
        public void AddBook(Book b);
        public void DeleteBook(Book b);
    }
}
