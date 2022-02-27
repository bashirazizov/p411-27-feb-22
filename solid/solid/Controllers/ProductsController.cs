using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using solid.DAL;
using solid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext db;

        public ProductsController(AppDbContext _db)
        {
            db = _db;
        }

        public IActionResult Info(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Product product = db.Products.Include(x => x.Comments).FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(product);
        }

        public IActionResult AddComment(string name, string email, string text, int prodId)
        {
            if (db.Products.FirstOrDefault(x=>x.Id == prodId)==null)
            {
                TempData["messageToUser"] = "get isinle mesgul ol";
                return RedirectToAction("Index", "Home");
            }

            Comment comment = new Comment();
            comment.CommenterName = name;
            comment.CommenterEmail = email;
            comment.CommentDate = DateTime.Now;
            comment.Text = text;
            comment.ProductId = prodId;

            db.Comments.Add(comment);
            db.SaveChanges();
            TempData["messageToUser"] = "Commentiniz ugurla elave olundu";
            return RedirectToAction("Info", "Products",new {id = prodId});
        }
        public IActionResult AddToBasket(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Product productToAddToBasket = db.Products.FirstOrDefault(x => x.Id == id);
            if (productToAddToBasket == null)
            {
                return RedirectToAction("Index", "Home");
            }

            List<BasketItem> basket;

            if (Request.Cookies["basket"] == null)
            {
                basket = new List<BasketItem>();
            }
            else
            {
                basket = JsonConvert.DeserializeObject<List<BasketItem>>(Request.Cookies["basket"]);
            }

            BasketItem existingBasketItem = basket.FirstOrDefault(x => x.product.Id == id);

            if (existingBasketItem == null)
            {
                basket.Add(new BasketItem(productToAddToBasket));
            }
            else
            {
                existingBasketItem.increaseCount();
            }

            string basketAsString = JsonConvert.SerializeObject(basket);
            Response.Cookies.Append("basket", basketAsString);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult DecreaseBasket(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (Request.Cookies["basket"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            List<BasketItem> basket = JsonConvert.DeserializeObject<List<BasketItem>>(Request.Cookies["basket"]);
            BasketItem itemToDecrease = basket.FirstOrDefault(x => x.product.Id == id);

            if (itemToDecrease == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (itemToDecrease.count > 1)
            {
                itemToDecrease.decreaseCount();
            }
            else
            {
                basket.Remove(itemToDecrease);
            }

            string basketAsString = JsonConvert.SerializeObject(basket);
            Response.Cookies.Append("basket", basketAsString);

            return RedirectToAction("ViewBasket", "Products");

        }

        public IActionResult IncreaseBasket(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (Request.Cookies["basket"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            List<BasketItem> basket = JsonConvert.DeserializeObject<List<BasketItem>>(Request.Cookies["basket"]);
            BasketItem itemToDecrease = basket.FirstOrDefault(x => x.product.Id == id);

            if (itemToDecrease == null)
            {
                return RedirectToAction("Index", "Home");
            }

            itemToDecrease.increaseCount();

            string basketAsString = JsonConvert.SerializeObject(basket);
            Response.Cookies.Append("basket", basketAsString);

            return RedirectToAction("ViewBasket", "Products");
        }
        public IActionResult ViewBasket()
        {
            List<BasketItem> basket;
            if (Request.Cookies["basket"] != null)
            {
                basket = JsonConvert.DeserializeObject<List<BasketItem>>(Request.Cookies["basket"]);

            }
            else
            {
                basket = new List<BasketItem>();
            }
            int basketTotal = 0;
            foreach (BasketItem item in basket)
            {
                basketTotal += item.totalPrice;
            }
            ViewBag.basketTotal = basketTotal;
            return View(basket);
        }
    }
}
