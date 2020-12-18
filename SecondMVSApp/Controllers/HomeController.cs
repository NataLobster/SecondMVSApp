using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SecondMVSApp.Models;

namespace SecondMVSApp.Controllers
{
    public class HomeController : Controller
    {
        //создаем контекс данных
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            // получаем все объекты (книги) из БД
            IEnumerable<Book> books = db.Books;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Books = books;
            //возвращаем представление
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            //указываем текущую дату
            purchase.Date = DateTime.Now;
            //добавляем данные в БД
            db.Purchases.Add(purchase);
            //сохраняем данные
            db.SaveChanges();
            //возвращаем сообщение
            return ($"Спасибо {purchase.Person} за покупку!");

        }

    }
}