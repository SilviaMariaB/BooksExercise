namespace ExercisesOOP
{
    public class Book
    {
        public string Name { get; set; }
        public Author Author { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Book(string name, Author author, double price)
        {
            Name = name;
            Author = author;
            Price = price;
        }

        public Book(string name, Author author, double price, int quantity)
        {
            Name = name;
            Author = author;
            Price = price;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"Book name: {Name}, author: {Author}, price: {Price}, copies available: {Quantity}.\n";
        }
    }
}
