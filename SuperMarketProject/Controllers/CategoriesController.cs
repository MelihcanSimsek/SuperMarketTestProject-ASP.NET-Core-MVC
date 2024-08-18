using Microsoft.AspNetCore.Mvc;
using SuperMarketProject.Models;

namespace SuperMarketProject.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoriesRepository.GetAllCategories();
            return View(categories);
        }

        public IActionResult Edit(int? id)
        {
            Category? category = CategoriesRepository.GetCategoryById(id.HasValue?id.Value:0);

            return View(category);
        }


        [HttpPost]
        public IActionResult Edit(Category category)
        {
            CategoriesRepository.UpdateCategory(category.CategoryId, category);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            CategoriesRepository.AddCategory(category);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? categoryId)
        {
            CategoriesRepository.DeleteCategory(categoryId.Value);
            return RedirectToAction(nameof(Index));
        }
    }
}
