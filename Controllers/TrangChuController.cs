using ShopOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ShopOnline.Controllers
{
    public class TrangChuController : Controller
    {
        QLBH2025Entities db = new QLBH2025Entities();

        // GET: /TrangChu/Index
        [HttpGet]
        public ActionResult Index()
        {
            var products = db.Products.Take(4).ToList();
            return View(products);
        }



        [HttpGet]
        public ActionResult Shop(string idCate, string keyword)
        {
            var categories = db.Categories.ToList();
            var products = db.Products.Include("Category").AsQueryable();

            // Lọc theo danh mục
            if (!string.IsNullOrEmpty(idCate))
                products = products.Where(p => p.IDCate != null && p.IDCate.Trim().ToUpper() == idCate.Trim().ToUpper());

            // Lọc theo từ khóa search
            if (!string.IsNullOrEmpty(keyword))
                products = products.Where(p => p.NamePro.Contains(keyword));

            ViewBag.Categories = categories;
            ViewBag.CurrentCategory = idCate?.Trim().ToUpper();
            ViewBag.Keyword = keyword; // giữ lại từ khóa trên view

            return View(products.ToList());
        }


        [HttpGet]
        public ActionResult Bestseller(string idCate)
        {

            // Lấy toàn bộ sản phẩm và danh mục
            var categories = db.Categories.ToList();
            var products = db.Products.Include("Category").ToList();

            // Nếu người dùng bấm vào một danh mục cụ thể
            if (!string.IsNullOrEmpty(idCate))
            {
                // So sánh ignore case và trim khoảng trắng
                products = products
                    .Where(p => p.IDCate != null && p.IDCate.Trim().ToUpper() == idCate.Trim().ToUpper())
                    .ToList();
            }

            // Truyền danh mục xuống view
            ViewBag.Categories = categories;
            ViewBag.CurrentCategory = idCate?.Trim().ToUpper(); // idCate?: idCate có thể null mà không lỗi , chir Trim() và ToUpper() nếu != null 
            // CurrentCategory danh mục đang chọn của user 
            return View(products);
        }

        [HttpGet]
        public ActionResult Collections(string idCate)
        {

            // Lấy toàn bộ sản phẩm và danh mục
            var categories = db.Categories.ToList();
            var products = db.Products.Include("Category").ToList();

            // Nếu người dùng bấm vào một danh mục cụ thể
            if (!string.IsNullOrEmpty(idCate))
            {
                // So sánh ignore case và trim khoảng trắng
                products = products
                    .Where(p => p.IDCate != null && p.IDCate.Trim().ToUpper() == idCate.Trim().ToUpper())
                    .ToList();
            }

            ViewBag.CurrentCategory = idCate?.Trim().ToUpper(); // idCate?: idCate có thể null mà không lỗi , chir Trim() và ToUpper() nếu != null 
            // Truyền danh mục xuống view
            ViewBag.Categories = categories;
            // CurrentCategory danh mục đang chọn của user 
            return View(products);
        }

        //========================================================


        [HttpGet]
        public JsonResult SearchSuggest(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
                return Json(new List<string>(), JsonRequestBehavior.AllowGet);

            var suggestions = db.Products
                .Where(p => p.NamePro.Contains(keyword))
                .Select(p => new
                {
                    p.ProductID,
                    p.NamePro,
                    p.ImagePro,
                    p.Price
                })
                .Take(8)
                .ToList();

            return Json(suggestions, JsonRequestBehavior.AllowGet);
        }


    }
}
