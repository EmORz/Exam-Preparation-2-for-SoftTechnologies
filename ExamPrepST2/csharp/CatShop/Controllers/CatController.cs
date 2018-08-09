namespace CatShop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using CatShop.Models;
    using System.Linq;

    public class CatController : Controller
    {
        private readonly CatDbContext context;

        public CatController(CatDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            // TODO
            var cats = context.Cats.ToList();
            return View(cats);
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            // TODO
            return View();
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create(Cat cat)
        {
            this.context.Update(cat);
            this.context.SaveChanges();
            return Redirect("/");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            // TODO
            var cat = this.context.Cats.Find(id);
            return View(cat);
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Cat catModel)
        {
            // TODO
            this.context.Update(catModel);
            this.context.SaveChanges();
            return Redirect("/");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            // TODO
            var cat = this.context.Cats.Find(id);
            return View(cat);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Cat catModel)
        {
            // TODO
            this.context.Cats.Remove(catModel);
            this.context.SaveChanges();
            return Redirect("/");
        }
    }
}
