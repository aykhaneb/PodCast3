using Microsoft.AspNetCore.Mvc;
using PodCast.DAL;
using System;

namespace PodCast.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
