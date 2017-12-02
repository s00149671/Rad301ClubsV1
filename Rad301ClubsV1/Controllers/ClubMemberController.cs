using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rad301ClubsV1.Controllers
{
    public class ClubMemberController : Controller
    {
        // GET: ClubMember
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClubMember/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClubMember/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClubMember/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ClubMember/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClubMember/Edit/5
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

        // GET: ClubMember/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClubMember/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
