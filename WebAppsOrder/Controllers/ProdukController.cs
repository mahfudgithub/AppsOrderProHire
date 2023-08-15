using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppsOrder.Controllers
{
    public class ProdukController : Controller
    {
        // GET: ProdukController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProdukController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProdukController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdukController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdukController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProdukController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdukController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProdukController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
