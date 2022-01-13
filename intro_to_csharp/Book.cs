using System;
namespace intro_to_csharp
{
    // Create a complex data type
    // what are the data types that would best describe the attributes?
    class Book
    {
        /// below variables are "class attributes"
        public string title;
        public string author;
        public int pages;

        // The args "public" and "Book" consist the "constructor"
        // Constructor will take parameters
        // "aTitle" stands for "argument Title"
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;

            Console.WriteLine();
        }

        // You can have several constructors

    }
}
