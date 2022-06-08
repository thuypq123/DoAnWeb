using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WepApp.Models;

namespace WepApp.Controllers
{
    public class ProductController : Controller
    {
        public readonly covid19Context _context;
        public ProductController()
        {
            _context = new covid19Context();
        }
        public IActionResult Index()
        {
            var viewSP = _context.Sanphams.ToList();
            return View(viewSP);
        }
        public IActionResult Details(int id)
        {
            //var sanpham = _context.Sanphams.Include(x => x.Madm).FirstOrDefault(x => x.Masp == id);
            //if (sanpham == null)
            //{
            //    return RedirectToAction("Index");
            //}
            return View();
        }
        public IActionResult Pagecarts()
        {
            return View();
        }
    }
}
