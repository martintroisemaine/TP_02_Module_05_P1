using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP_02_Module_05_P1.Models;
using TP_02_Module_05_P1.Utils;

namespace TP_02_Module_05_P1.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {
            return View(FakeDbCat.Instance.Pizzas);
        }

        // GET: Pizza/Details/5
        public ActionResult Details(int id)
        {
            Pizza pizza = FakeDbCat.Instance.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza != null)
            {
                return View(pizza);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        // GET: Pizza/Create
        public ActionResult Create()
        {
            return View(new ViewModel());
        }

        // POST: Pizza/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {

                Pizza pizza = new Pizza((FakeDbCat.Instance.Pizzas.LastOrDefault() == null ? 0 : FakeDbCat.Instance.Pizzas.LastOrDefault().Id), collection["Nom"], FakeDbCat.Instance.Pates[Convert.ToInt32(collection["Pate"])], new List<Ingredient> { FakeDbCat.Instance.Ingredients[Convert.ToInt32(collection["Ingredients"])] });

                FakeDbCat.Instance.Pizzas.Add(pizza);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pizza/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Delete/5
        public ActionResult Delete(int id)
        {
            Pizza pizza = FakeDbCat.Instance.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza != null)
            {
                return View(pizza);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        // POST: Pizza/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Pizza pizza = FakeDbCat.Instance.Pizzas.FirstOrDefault(x => x.Id == id);
                FakeDbCat.Instance.Pizzas.Remove(pizza);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
