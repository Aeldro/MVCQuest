using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCQuest.Models.Entities;
using MVCQuest.Repositories;

namespace MVCQuest.Controllers
{
    public class ArticleController : Controller
    {
        [HttpGet]
        public IActionResult List() => View(ArticleRepository.GetArticles());

        [HttpGet]
        public IActionResult Edit(int id) => View(ArticleRepository.GetArticle(id));

        [HttpPost]
        public IActionResult Edit(Article article)
        {
            ArticleRepository.EditArticle(article);
            return RedirectToAction("List", "Article");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            ArticleRepository.DeleteArticle(id);
            return RedirectToAction("List", "Article");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string title, string text)
        {
            ArticleRepository.CreateArticle(title, text);
            return RedirectToAction("List", "Article");
        }
    }
}
