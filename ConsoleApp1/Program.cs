namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookAccounting bookAccounting = new BookAccounting();
            bookAccounting.AddBookToBegin("bob", "A1", "asd");
            bookAccounting.AddBookToBegin("bob", "A2", "asd");
            bookAccounting.AddBookToBegin("bobfg", "A2", "asd");
            bookAccounting.ShowBooks();
            Console.WriteLine("====================");
            bookAccounting.DelBookInBegin();
            bookAccounting.ShowBooks();
            Console.WriteLine("====================");
            bookAccounting.DelBookInEnd();
            bookAccounting.ShowBooks();
            Console.WriteLine("====================");
            bookAccounting.AddBookToBegin("Book1", "A2", "asd");
            bookAccounting.AddBookToBegin("Book2", "A3", "asd");
            bookAccounting.AddBookToBegin("Book3", "A4", "asd");
            bookAccounting.ShowBooks();
            Console.WriteLine("====================");
            Console.WriteLine("Search book: \n{0}", bookAccounting.SearchBookByName("Book2"));
        }
    }
}
