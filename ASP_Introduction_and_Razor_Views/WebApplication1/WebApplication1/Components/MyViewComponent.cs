using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Components
{
    [ViewComponent(Name = "CustomComponent")]
    public class MyViewComponent : ViewComponent
    {
        private ICustomViewData customViewData;
        public MyViewComponent(ICustomViewData customViewData)
            => this.customViewData = customViewData;
        public IViewComponentResult Invoke(string someData)
        {
            var data = customViewData.GetViewData();

            var model = new CatViewModel
            {
                Name = data
            };

            this.ViewBag.FromViewComponent = $"Some value + {someData}";
            return View(model);
        }
    }
}
