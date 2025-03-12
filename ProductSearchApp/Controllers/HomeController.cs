using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductSearchApp.Models;

namespace ProductSearchApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public async Task<JsonResult> Search(string searchTerm)
    {
        using (var db = new ProductDb())
        {
            db.Database.EnsureCreated();
			var products =await db.Product.Where(u => u.ProductName.Contains(searchTerm) ||
                    u.ProductDesc.Contains(searchTerm))
                    .ToListAsync();
            if (!products.Any())
                return Json(new BaseResponse() { IsSuccess = false });
            return Json(new BaseResponse() { Data = products,IsSuccess = true});
		}

    }
}
