using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Book
    {
        
        public int ID;
        public string Title;
        public string Author;
        public Book(int id, string title, string author)
        {
            ID = id;
            Title = title;
            Author = author;
        }
        public void display()
        {
            Console.WriteLine("Book ID is:" +  ID);
            Console.WriteLine("Book Title is:" + Title);
            Console.WriteLine("Author is:" + Author);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Display Books");
                Console.WriteLine("3. Remove Book");
                Console.WriteLine("4. Exit");

                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Enter the book id:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the title of book:");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter the author:");
                    string author = Console.ReadLine();

                    Book b = new Book(id, title, author);
                    books.Add(b);
                }
                else if (option == 2)
                {
                    foreach (Book book in books)
                    {
                        book.display();
                    }
                }
                else if (option == 3)
                {
                    Console.WriteLine("Enter the book id you want to remove:");
                    int id = int.Parse(Console.ReadLine());
                    for(int i = 0; i < books.Count; i++)
                    {
                        if (books[i].ID == id)
                        {
                            books.RemoveAt(i);
                            break;
                        }
                    }
                }
                else if (option == 4)
                {
                    break;
                }
            }
        }
    }
}
