using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle=context.Abouts.Select(a => a.Title).FirstOrDefault();
            ViewBag.aboutSubDescription=context.Abouts.Select(a => a.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail=context.Abouts.Select(a => a.Details).FirstOrDefault();
            return View();
        }
    }
}
