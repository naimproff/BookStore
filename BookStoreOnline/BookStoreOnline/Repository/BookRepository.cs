using BookStoreOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreOnline.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().FirstOrDefault(c => c.Id == id);
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(c => c.Title.Contains(title) || c.Author.Contains(author)).ToList();
        }


        private List<BookModel> DataSource()
        {
            return new List<BookModel>
            {
                new BookModel{ Id = 1, Title = "MVC Book", Author = "Rakib Khan" },
                new BookModel{ Id = 2, Title = "C# Book", Author = "Sejnu Khan" },
                new BookModel{ Id = 3, Title = "Angular Book", Author = "Yaasin Khan" },
                new BookModel{ Id = 4, Title = "React Book", Author = "Naimur Rahman" },
                new BookModel{ Id = 5, Title = "Vue Book", Author = "Nobab Khan" },
            };
        }

    }
}
