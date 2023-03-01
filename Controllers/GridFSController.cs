using GridFSCreateEditAndDisplay.Models;
using GridFSCreateEditAndDisplay.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GridFSCreateEditAndDisplay.Controllers
{
    public class GridFSController : Controller
    {
        private readonly IInfoServices _service;

        public GridFSController(IInfoServices service)
        {
            _service = service;
        }
        // GET: GridFSController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GridFSController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GridFSController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GridFSController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Image imageDetails)
        {
            _service.Create(imageDetails);
            return RedirectToAction("Index");
        }

        // GET: GridFSController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GridFSController/Edit/5
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

        // GET: GridFSController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GridFSController/Delete/5
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
