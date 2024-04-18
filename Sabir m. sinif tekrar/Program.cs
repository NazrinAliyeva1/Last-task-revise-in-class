using Sabir_m._sinif_tekrar.Methods;

namespace Sabir_m._sinif_tekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Sefiller", "Victor Hugo");
            Book book2 = new Book("The Author to Her Book", "Anne Dudley Bradstreet");

            Library library = new Library();

            library.AddBook(book);
            library.AddBook(book2);

            Book book3 = library[1];
            if (book3 == null)
            {
                Console.WriteLine("Book not found");
            }
            else
            {
                Console.WriteLine(book3.Name + " " + book3.Author);
            }
        }
    }
}
