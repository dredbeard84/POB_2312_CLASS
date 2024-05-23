using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thema31_2
{
    
    public class Library
    {
        private List<Book> list;
        public Library()
        {
            list = new List<Book>();
        }
        public void Add(Book book)
        {
            list.Add(book);
        }
        public void Remove(string title)
        {
            Book book = list.FirstOrDefault(p => p.getTitle() == title)!;
            list.Remove(book);
        }
        public int getCount() => list.Count;
        public List<Book> getBooks() => list;
        public List<Book> getBooksByCriteria(string name)
        {
            List<Book> books = list.Where(p => p.getTitle().StartsWith(name) || 
                                               p.getAuthor().StartsWith(name)).ToList();
            if (books.Count == 0)
            {
                int year;
                int.TryParse(Console.ReadLine(), out year);
                books = list.Where(p => p.getYear() == year).ToList();
            }
            return books;
        }
    }
}