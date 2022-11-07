using BookStoreOnline.Models;
using BookStoreOnline.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreOnline.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _repository;
        public BookController()
        {
            _repository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            return View(_repository.GetAllBooks());
        }


        public ViewResult GetBook(int id)
        {
            return View(_repository.GetBookById(id));
        }
    }
}
