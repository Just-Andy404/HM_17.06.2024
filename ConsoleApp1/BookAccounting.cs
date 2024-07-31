using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BookAccounting
    {
        private LinkedList<Book> _books;
        public BookAccounting()
        {
            _books = new LinkedList<Book>();
        }
        public void AddBookToBegin()
        {
            _books.AddFirst(new Book());
        }
        public void AddBookToBegin(string name, string author, string description)
        {
            _books.AddFirst(new Book(name, author, description));
        }
        public void AddBookToEnd()
        {
            _books.AddLast(new Book());
        }
        public void InsertBookAtPosition(Book book, int position)
        {
            if (position < 0 || position > _books.Count)
            {
                throw new Exception("Not in range");
            }
            else if (position == 0)
            {
                _books.AddFirst(book);
                return;
            }
            else if (position == _books.Count)
            {
                _books.AddLast(book);
                return;
            }
            else
            {
                LinkedListNode<Book> current = _books.First;
                for (int i = 0; i < position; i++)
                {
                    current = current.Next;
                }
                _books.AddBefore(current, book);
            }
        }
        public void UpdateBook(Book oldBook, Book newBook)
        {
            LinkedListNode<Book> node = _books.Find(oldBook);
            if (node != null)
            {
                node.Value = newBook;
            }
        }
        public void ChangeBook(string oldName, Book newBook)
        {
            LinkedListNode<Book> current = _books.First;
            while (current != null)
            {
                if (current.Value.Name == oldName)
                {
                    current.Value = newBook;
                    break;
                }
                current = current.Next;
            }
        }
        public Book SearchBookByName(string name)
        {
            LinkedListNode<Book> current = _books.First;
            while (current != null)
            {
                if (current.Value.Name == name)
                {
                    break;
                }
                current = current.Next;
            }
            return current.Value;
        }
        public Book SearchBookByAuthor(string author)
        {
            LinkedListNode<Book> current = _books.First;
            while (current != null)
            {
                if (current.Value.Author == author)
                {
                    break;
                }
                current = current.Next;
            }

            return current.Value;
        }
        public void DelBookInBegin()
        {
            _books.RemoveFirst();
        }
        public void DelBookInEnd()
        {
            _books.RemoveLast();
        }
        public void DelBookInPos(int position)
        {
            if (position < 0 || position > _books.Count)
            {
                throw new Exception("Not in range");
            }
            else if (position == 0)
            {
                _books.RemoveFirst();
                return;
            }
            else if (position == _books.Count)
            {
                _books.RemoveLast();
                return;
            }
            else
            {
                LinkedListNode<Book> current = _books.First;
                for (int i = 0; i < position; i++)
                {
                    current = current.Next;
                }
                _books.Remove(current);
            }
        }
        public void ShowBooks()
        {
            foreach (Book book in _books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
