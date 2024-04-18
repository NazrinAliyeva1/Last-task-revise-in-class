using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabir_m._sinif_tekrar.Methods
{
    internal class Library
    {
        Book[] _books = new Book[0];
        public Book[] Books { get { return _books; } }

        public Book this[int il]
        {
            get
            {
                foreach(Book book in _books)
                {
                    if (book.Id ==il){
                        return book;
                    }
                }
                return null;
            }
        }
        public void AddBook(Book book)
        {
            Array.Resize(ref _books, _books.Length + 1);
            _books[_books.Length - 1] = book;
        }

    }
}
