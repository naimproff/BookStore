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
                new BookModel
                {
                    Id = 1,
                    Title = "MVC Book",
                    Author = "Rakib Khan",
                    Description= "Some quick example text to build,Some quick example text to build , Some quick example text to build",
                    Category = "Programming",
                    Language = "English",
                    TotalPages = 502
                },
                new BookModel
                {
                    Id = 2,
                    Title = "Angular Book",
                    Author = "Rain Dolly",
                    Description= "Some quick example text to build,Some quick example text to build , Some quick example text to build",
                    Category = "Programming",
                    Language = "English",
                    TotalPages = 502
                },
                new BookModel
                {
                    Id = 3,
                    Title = "React Book",
                    Author = "Rakib Khan",
                    Description= "Some quick example text to build,Some quick example text to build , Some quick example text to build",
                    Category = "Programming",
                    Language = "English",
                    TotalPages = 502
                },
                new BookModel
                {
                    Id = 4,
                    Title = "React Native Book",
                    Author = "Refat Khan",
                    Description= "Some quick example text to build,Some quick example text to build , Some quick example text to build",
                    Category = "Programming",
                    Language = "English",
                    TotalPages = 502
                },
                new BookModel
                {
                    Id = 5,
                    Title = "C-Sharp Book",
                    Author = "John Doe",
                    Description= "Some quick example text to build,Some quick example text to build , Some quick example text to build",
                    Category = "Programming",
                    Language = "English",
                    TotalPages = 502
                },
                new BookModel
                {
                    Id = 6,
                    Title = "TypeScript Book",
                    Author = "Smith Reddy",
                    Description= "Some quick example text to build,Some quick example text to build , Some quick example text to build",
                    Category = "Programming",
                    Language = "English",
                    TotalPages = 502
                },

            };
        }

    }
}
