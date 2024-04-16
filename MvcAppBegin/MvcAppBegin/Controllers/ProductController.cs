using System;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using MvcAppBegin.Models;

namespace MvcAppBegin.Controllers
{
	public class ProductController:Controller
	{
        private List<Product>? _products;

        public ProductController()
        {
            _products = new List<Product>()
            {
                new Product{Id=1,Name="samsung",Price=87},
                      new Product{Id=2,Name="iphone",Price=103},
                      new Product{Id=3,Name="nokia",Price=45},
                      new Product{Id=4,Name="honor",Price=413},
                     new Product{Id=5,Name="redmi",Price=123},
                  };
        }
        public JsonResult GetAll()
        {
            return Json(_products);
        }
        public ViewResult Index()
        {
            ViewBag.Products = _products;

            return View();
        }
        public ViewResult Details(int id)
        {
            Product? product = _products?.FirstOrDefault(x => x.Id == id);
            ViewBag.Product = product;
            return View();
        }

    }
}

