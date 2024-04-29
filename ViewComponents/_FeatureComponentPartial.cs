using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            MyPortfolioContext context = new MyPortfolioContext();

            var values = context.Features.ToList();
            return View(values);
        }
    }
}
