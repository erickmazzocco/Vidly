using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly2.Models;

namespace Vidly.Controllers
{
    public class CustumersController : Controller
    {
        private ApplicationDbContext _context;

        public CustumersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var custumers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(custumers);
        }

        public ActionResult Details(int Id)
        {
            var custumers = _context.Customers.First(x => x.Id == Id);

            if (custumers == null)
                return HttpNotFound();

            return View(custumers);
        }        
    }
}