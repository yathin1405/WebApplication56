using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication56.Models;
using Microsoft.AspNet.Identity;

namespace WebApplication56.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult CustomerDashBord()
        {

            string s = User.Identity.GetUserName();
            var UsCustomers = db.Customers.Where(p => p.Email.Equals(s)).FirstOrDefault();


            if (UsCustomers == null)
            {
                @ViewBag.ResultMessage = "the is no user logged in";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                @ViewBag.userID = "Customer";
                Customer aCustomers = db.Customers.Find(UsCustomers.CustomerId);

                return View(aCustomers);
            }

        }


        //[HttpPost]

        //[ValidateAntiForgeryToken]
        //public ActionResult GetLearner(string LearnerID)
        //{
        //    if (!string.IsNullOrWhiteSpace(LearnerID))
        //    {
        //        Student Learner = db.Students.Where(u => u.IdentityNumber.Equals(LearnerID, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();


        //        if (Learner == null)
        //        {
        //            ViewBag.GetLearner = "Notfind";
        //            ViewBag.ResultMessage = "The IdentityNumber did not match any registered Student";
        //        }
        //        else if (Learner != null)
        //        {
        //            ViewBag.GetLearner = "find";
        //            ViewBag.LeanersEmail = Learner.Email;
        //            ViewBag.Fullname = Learner.FullName();
        //            ViewBag.StudentId = Learner.IdentityNumber;
        //        }
        //    }
        //    else
        //    {
        //        ViewBag.GetLearner = "Notfind";
        //        ViewBag.ResultMessage = "You did not enter any thing";
        //    }
        //    string s = User.Identity.GetUserName();
        //    var UsParents = db.parents.Where(p => p.Email.Equals(s)).FirstOrDefault();
        //    Parent aParents = db.parents.Find(UsParents.ParentId);

        //    return View("ParentDashBord", aParents);
        //}




        public ActionResult AddLearner(string LearnerEmail, int CustomerID)
        {
            return RedirectToAction("confirmLearn", "ParentLearners", new { ConfLearnerEmail = LearnerEmail, ConfCustomerID = CustomerID });
        }




        [HttpGet]
        // GET: Customer
        public ActionResult Index()
        {

            ViewBag.ResultMessage = TempData["ResultMessage"];

            return View(db.Customers.ToList());
        }


        // GET: Customers
        //public ActionResult Index()
        //{
        //    return View(db.Customers.ToList());
        //}

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerId,FName,MName,LName,Title,IdentityNumber,Gender,Email")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerId,FName,MName,LName,Title,IdentityNumber,Gender,Email")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
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
