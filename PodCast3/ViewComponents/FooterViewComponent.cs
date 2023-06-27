using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PodCast.DAL;


namespace PodCast.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;
        public FooterViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var footer = _dbContext.Footer.Include(x => x.SocialMedia).FirstOrDefault();

            return View(footer);
        }
    }
}
