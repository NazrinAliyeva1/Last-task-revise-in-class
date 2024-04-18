using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabir_m._sinif_tekrar.Methods
{
    internal class Book
    {
        static int Count = 0;
        public int Id { get; set; } = 1;
        public string Name;
        public string Author;

        public Book(string name, string author)
        {
            Name = name;
            Author = author;
            Id = Count++;
            
        }


    }
}
