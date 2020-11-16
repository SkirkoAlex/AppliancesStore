using AppliancesStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace AppliancesStore.Controllers
{
    public class HomeController : Controller
    {
        ProductContext db = new ProductContext();
        public ActionResult Index()
        {
            return View(db.Products);
        }

        public ActionResult GetCategory()
        {
            string[] categories = new string[] { "Холодильники", "Стиральные машины", "Планшеты", "Наушники" };
            return View(categories);
        }

        /// <summary>
        /// Возвращает число товаров по указанной категории
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public string CountNumberProductsInCategory(string category)
        {
            var countProdects = db.Products.Count(x => x.Category == category);
            if (countProdects==0)
            {
                return $"<h2>В выбранной категории товары отсутствуют! </h2>";
            }
            return $"<h2>Число товаров в выбранной категории: {countProdects} </h2>";
        }

        /// <summary>
        /// Скачивает файл
        /// </summary>
        /// <returns></returns>
        public FileResult GetFile()
        {
            string path = Server.MapPath(@"~/Files/Price.xlsx");
            string type = "application/xlsx";
            string name = "Price.xlsx";
            return File(path, type, name);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Buy(Guid id)
        {
            ViewBag.Product = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return $"Спасибо, {purchase.Customer}, за покупку! Вашу покупку доставят по адресу: {purchase.Address}";
        }
    }
}