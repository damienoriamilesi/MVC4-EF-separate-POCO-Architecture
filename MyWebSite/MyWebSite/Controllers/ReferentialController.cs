using System.Web.Mvc;
using MyWebSite.Domain;
using MyWebSite.Service;

namespace MyWebSite.Controllers
{
    public class ReferentialController : Controller
    {
        private readonly IReferentialService _service;

        public ReferentialController(IReferentialService service)
        {
            _service = service;
        }
        //
        // GET: /Default1/

        public ActionResult Index()
        {

            return View(_service.GetAllEntities());
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id = 0)
        {
            //Entity1 entity1 = 
            //if (entity1 == null)
            //{
            //    return HttpNotFound();
            //}
            return View(new object());
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        public ActionResult Create(Entity1 entity1)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View(entity1);
        }

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            var entity1 = new Entity1(); //Find(id);
            if (entity1 == null)
            {
                return HttpNotFound();
            }
            return View(entity1);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        public ActionResult Edit(Entity1 entity1)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(entity1);
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            //Entity1 entity1 = db.Entity1.Find(id);
            //if (entity1 == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(entity1);
            return View(new object());
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            //Entity1 entity1 = db.Entity1.Find(id);
            //db.Entity1.Remove(entity1);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            //db.Dispose();
            base.Dispose(disposing);
        }
    }
}