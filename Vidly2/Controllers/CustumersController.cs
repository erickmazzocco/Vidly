using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustumersController : Controller
    {
        public ViewResult Index()
        {
            var custumers = GetCustumers();

            return View(custumers);
        }

        public ViewResult Details(int Id)
        {
            return View(GetCustumers().First(x => x.Id == Id));
        }

        private IEnumerable<Custumer> GetCustumers()
        {
            return new List<Custumer>()
            {
                new Custumer()
                {
                    Id = 1, Name = "Linguiça"
                },
                new Custumer()
                {
                    Id = 2, Name = "Paçoca"
                }
            };
        }

        private IEnumerable<Custumer> GetEmptyCustumer()
        {
            return new List<Custumer>();
        }
        
    }
}