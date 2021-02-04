using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? id)
        {
            var books = BookRepository.Books;

            if (id != null)
            {
                books = books.Where(b => b.CategoryId == id).ToList();
            }

            return View(books);
        }

        public IActionResult Details(int id)
        {
            return View(BookRepository.GetById(id));
        }
    }
}