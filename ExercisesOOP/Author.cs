using System;

namespace ExercisesOOP
{
    public class Author
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }

        public Author(string name, string email, Gender gender)
        {
            Name = name;
            Email = email;
            Gender = gender;
        }

        public static string ReadString(string message)
        {
            Console.Write($"Enter {message}: ");
            return Console.ReadLine();
        }

        public static Author Create()
        {
            string name = Author.ReadString("name");
            string email = Author.ReadString("email");
            string inputGender = Author.ReadString("gender");

            if (Enum.TryParse(inputGender, true, out Gender gender))
            {
                if (!Enum.IsDefined(typeof(Gender), gender))
                {
                    gender = default;
                }
            }

            return new Author(name, email, gender);
        }

        public override string ToString()
        {
            return $"Author: {Name}, email: {Email}, gender: {Gender}.";
        }
    }
}
