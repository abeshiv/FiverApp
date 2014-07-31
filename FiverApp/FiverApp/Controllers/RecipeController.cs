using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FiverApp;

namespace FiverApp.Controllers
{
    public class RecipeController : Controller
    {
        private FiverDBEntities db = new FiverDBEntities();

        // GET: /Recipe/
        public ActionResult Index()
        {
            var recipes = db.Recipes.Include(r => r.Ingredient).Include(r => r.Ingredient11).Include(r => r.Ingredient12).Include(r => r.Ingredient13).Include(r => r.Ingredient14).Include(r => r.Ingredient15).Include(r => r.Ingredient16).Include(r => r.Ingredient17).Include(r => r.Ingredient18).Include(r => r.Ingredient19);
            return View(recipes.ToList());
        }

        // GET: /Recipe/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        // GET: /Recipe/Create
        public ActionResult Create()
        {
            ViewBag.Ingredient1 = new SelectList(db.Ingredients, "IngredientId", "IngredientName");
            ViewBag.Ingredient10 = new SelectList(db.Ingredients, "IngredientId", "IngredientName");
            ViewBag.Ingredient2 = new SelectList(db.Ingredients, "IngredientId", "IngredientName");
            ViewBag.Ingredient3 = new SelectList(db.Ingredients, "IngredientId", "IngredientName");
            ViewBag.Ingredient4 = new SelectList(db.Ingredients, "IngredientId", "IngredientName");
            ViewBag.Ingredient5 = new SelectList(db.Ingredients, "IngredientId", "IngredientName");
            ViewBag.Ingredient6 = new SelectList(db.Ingredients, "IngredientId", "IngredientName");
            ViewBag.Ingredient7 = new SelectList(db.Ingredients, "IngredientId", "IngredientName");
            ViewBag.Ingredient8 = new SelectList(db.Ingredients, "IngredientId", "IngredientName");
            ViewBag.Ingredient9 = new SelectList(db.Ingredients, "IngredientId", "IngredientName");
            return View();
        }

        // POST: /Recipe/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="RecipeId,Name,RecipeType,Servings,Directions,PrepTime,CookTime,Ingredient1,Ingredient2,Ingredient3,Ingredient4,Ingredient5,Ingredient6,Ingredient7,Ingredient8,Ingredient9,Ingredient10")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                db.Recipes.Add(recipe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Ingredient1 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient1);
            ViewBag.Ingredient10 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient10);
            ViewBag.Ingredient2 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient2);
            ViewBag.Ingredient3 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient3);
            ViewBag.Ingredient4 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient4);
            ViewBag.Ingredient5 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient5);
            ViewBag.Ingredient6 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient6);
            ViewBag.Ingredient7 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient7);
            ViewBag.Ingredient8 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient8);
            ViewBag.Ingredient9 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient9);
            return View(recipe);
        }

        // GET: /Recipe/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            ViewBag.Ingredient1 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient1);
            ViewBag.Ingredient10 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient10);
            ViewBag.Ingredient2 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient2);
            ViewBag.Ingredient3 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient3);
            ViewBag.Ingredient4 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient4);
            ViewBag.Ingredient5 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient5);
            ViewBag.Ingredient6 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient6);
            ViewBag.Ingredient7 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient7);
            ViewBag.Ingredient8 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient8);
            ViewBag.Ingredient9 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient9);
            return View(recipe);
        }

        // POST: /Recipe/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="RecipeId,Name,RecipeType,Servings,Directions,PrepTime,CookTime,Ingredient1,Ingredient2,Ingredient3,Ingredient4,Ingredient5,Ingredient6,Ingredient7,Ingredient8,Ingredient9,Ingredient10")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recipe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Ingredient1 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient1);
            ViewBag.Ingredient10 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient10);
            ViewBag.Ingredient2 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient2);
            ViewBag.Ingredient3 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient3);
            ViewBag.Ingredient4 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient4);
            ViewBag.Ingredient5 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient5);
            ViewBag.Ingredient6 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient6);
            ViewBag.Ingredient7 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient7);
            ViewBag.Ingredient8 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient8);
            ViewBag.Ingredient9 = new SelectList(db.Ingredients, "IngredientId", "IngredientName", recipe.Ingredient9);
            return View(recipe);
        }

        // GET: /Recipe/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        // POST: /Recipe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recipe recipe = db.Recipes.Find(id);
            db.Recipes.Remove(recipe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
