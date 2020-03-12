using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCtest.Controllers
{
    public class BookController : Controller
    {
        public ActionResult Index()
        {
  
                var book = new MVCtest.Models.book()
                {
                    ID = 01,
                    Title = "Java for Dummies",
                    Description = "Basics",
                    Author = "Raymark",
                    Publisher = "Raymark",
                    DatePublished = "03/30/2020",
                    BookFormat = "Book Bind",


                };
                return View(book);
        }
        public ActionResult List()
        {
            var book = new MVCtest.Models.book();
            var list = new MVCtest.Models.book()
            {
                ID = book.ID,
                Title = book.Title,
                Description = book.Description,
                Author = book.Author,
                Publisher = book.Publisher,
                DatePublished = book.DatePublished,
                BookFormat = book.BookFormat,


            };
            return View(list);


        }
    }
}