using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcWebUI.Models;

namespace MvcWebUI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        ICategoryServices _categoryServices;

        public CategoryListViewComponent(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryServices.GetAll()
            };
            return View(model);
        }
    }
}
