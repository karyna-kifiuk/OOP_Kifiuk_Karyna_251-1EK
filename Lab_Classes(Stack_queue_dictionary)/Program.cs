using System;
using System.Collections.Generic;

// 1 завдання
namespace StackDocuments
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Document> documents = new Stack<Document>();

            Document document1 = new Document("Док 1");
            Document document2 = new Document("Док 2");
            Document document3 = new Document("Док 3");
            documents.Push(document1);
            documents.Push(document2);
            documents.Push(document3);

            Document topDocument = documents.Peek();
            Console.WriteLine("Верхній док: {0}", topDocument.Title);

            documents.Pop();

            topDocument = documents.Peek();
            Console.WriteLine("Верхній док: {0}", topDocument.Title);
            Console.ReadLine();
        }
    }
    class Document
    {
        public string Title { get; set; }

        public Document(string title)
        {
            Title = title;
        }
    }
}

//2 завдання
namespace QueueOrders
{
    class Program
    {
        static void EnqueueOrder(string[] args)
        {
            Queue<Order> orders = new Queue<Order>();

            Order order1 = new Order("Суші", 100);
            Order order2 = new Order("Суп", 50);
            Order order3 = new Order("Салат", 70);
            orders.Enqueue(order1);
            orders.Enqueue(order2);
            orders.Enqueue(order3);

            Order oldestOrder = orders.Peek();
            Console.WriteLine("Найстарше замовлення: {0} {1}", oldestOrder.Dish, oldestOrder.Price);

            orders.Dequeue();

            oldestOrder = orders.Peek();
            Console.WriteLine("Найстарше замовлення: {0} {1}", oldestOrder.Dish, oldestOrder.Price);
            Console.ReadLine();
        }
    }
    class Order
    {
        public string Dish { get; set; }
        public int Price { get; set; }

        public Order(string dish, int price)
        {
            Dish = dish;
            Price = price;
        }
    }
}

//3 завдання
namespace BookStoreDictionary
{
    class Program
    {
        static void PrintBookById(string[] args)
        {
            Dictionary<int, Book> books = new Dictionary<int, Book>();

            Book book1 = new Book(1, "1984", "Дж. Оруелл", 140);
            Book book2 = new Book(2, "Я чую вас наскрізь", "М. Гоулстон", 360);
            Book book3 = new Book(3, "Фінансист", "Т. Драйзер", 550);
            books.Add(book1.Id, book1);
            books.Add(book2.Id, book2);
            books.Add(book3.Id, book3);

            Book book = books[1];
            Console.WriteLine("Інформація про книгу:");
            Console.WriteLine("Ідентифікатор: {0}", book.Id);
            Console.WriteLine("Назва: {0}", book.Title);
            Console.WriteLine("Автор: {0}", book.Author);
            Console.WriteLine("Ціна: {0}", book.Price);

            books.Remove(2);

            book = books[1];
            Console.WriteLine("Інформація про книгу:");
            Console.WriteLine("Ідентифікатор: {0}", book.Id);
            Console.WriteLine("Назва: {0}", book.Title);
            Console.WriteLine("Автор: {0}", book.Author);
            Console.WriteLine("Ціна: {0}", book.Price);

            Console.ReadLine();
        }
    }
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public Book(int id, string title, string author, int price)
        {
            Id = id;
            Title = title;
            Author = author;
            Price = price;
        }
    }
}
