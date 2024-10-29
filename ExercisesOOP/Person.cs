using System.Collections.Generic;
using System.Text;

namespace ExercisesOOP
{
    public class Person
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, List<Book> books)
        {
            Name = name;
            Books = books;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Your name is {Name} and your books are:");
            foreach (Book book in Books)
            {
                sb.AppendLine(book.ToString());
            }
            return sb.ToString();
        }
    }
}

