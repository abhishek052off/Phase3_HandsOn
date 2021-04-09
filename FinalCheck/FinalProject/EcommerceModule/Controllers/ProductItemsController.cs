using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EcommerceModule.DAL;
using EcommerceModule.Models;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace EcommerceModule.Controllers
{
    [Authorize]
    public class ProductItemsController : Controller
    {
        private readonly EcommDBContext _context;
        HttpClient client;
        public ProductItemsController(EcommDBContext context)
        {
            _context = context;
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44329/");
        }

        // GET: ProductItems
        public IActionResult Index()
        {
            IEnumerable<ProductItem> productsList = null;

            var responseTask = client.GetAsync("Products");
            responseTask.Wait();

            var result = responseTask.Result;
            HttpResponseMessage response;
            try
            {
              
                response = client.GetAsync(client.BaseAddress + "api/Products").Result;
            }
            catch
            {
                return RedirectToAction("Error");
            }

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                productsList = JsonConvert.DeserializeObject<List<ProductItem>>(data);
                return View(productsList);
            }
            return RedirectToAction("Error");
        }

        public ActionResult Search()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Search(Search obj)
        {
            var isNumeric = int.TryParse(obj.str, out int n);
            if (isNumeric)
                return RedirectToAction("Details", new { id = obj.str });
            else
                return RedirectToAction("DetailsByName",new { name=obj.str});
        }

        public IActionResult DetailsByName(string name)
        {
            ProductItem product = new ProductItem();

            HttpResponseMessage response;
            try
            {
                response = client.GetAsync(client.BaseAddress + $"api/Products/name={name}").Result;
            }
            catch
            {
                return RedirectToAction("Error");
            }

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                product = JsonConvert.DeserializeObject<ProductItem>(data);
                return View("Details",product);
            }
            ViewBag.Error = "Product not found!";
            return View("Search");
        }
        // GET: ProductItems/Details/5
        public  IActionResult Details(int? id)
        {
            ProductItem product = new ProductItem();
            HttpResponseMessage response;
            try
            {
                response = client.GetAsync(client.BaseAddress + $"api/Products/id={id}").Result;
            }
            catch
            {
                return RedirectToAction("Error");
            }

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                product = JsonConvert.DeserializeObject<ProductItem>(data);
                return View(product);
            }
            ViewBag.Error = "Product not found!";
            return View("Search");
        }

        public IActionResult Edit(int? id)
        {
            ProductItem product = new ProductItem();
            HttpResponseMessage response;
            try
            {
                response = client.GetAsync(client.BaseAddress + $"api/Products/id={id}").Result;
            }
            catch
            {
                return RedirectToAction("Error");
            }

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                product = JsonConvert.DeserializeObject<ProductItem>(data);
                return View(product);
            }
            return RedirectToAction("Error");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ProductItem productItem)
        {
            string data = JsonConvert.SerializeObject(productItem);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpResponseMessage response;
            try
            {
                response = client.PutAsync(client.BaseAddress + "api/Product/" + productItem.Id, content).Result;
            }
            catch
            {
                return RedirectToAction("Error");
            }
            if (response.IsSuccessStatusCode)
                return RedirectToAction("Index");
            return RedirectToAction("Error");


        }

        // GET: ProductItems/Delete/5
       

        // POST: ProductItems/Delete/5
        

        private bool ProductItemExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
