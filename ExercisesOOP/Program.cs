using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ExercisesOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author1 = new Author("John", "john@books.com", Gender.Male);
            Console.WriteLine(author1);

            Author author2 = new Author("Jena", "jena@books.com", Gender.Female);
            Console.WriteLine(author2);

            //Author author3 = Author.Create();
            // Console.WriteLine(author3);

            Book book1 = new Book("Cartea lui Chimen", author1, 23.34, 3);
            Book book2 = new Book("Cartea lui Dode", author2, 13.5, 4);
            Book book3 = new Book("Cartea lui Cata", author1, 7, 10);

            Console.WriteLine();

            Console.WriteLine(book1);

            Console.WriteLine();

            Console.WriteLine(book2);

            Console.WriteLine();

            Console.WriteLine(book3);

            Console.WriteLine();

            List<Book> books1 = new List<Book>();

            books1.Add(book1);
            books1.Add(book2);
            books1.Add(book3);

            Person person1 = new Person("Dode", books1);
            Console.WriteLine(person1);
        }
    }
}
