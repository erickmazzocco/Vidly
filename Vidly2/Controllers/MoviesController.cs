using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        public ViewResult Details(int Id)
        {
            return View(GetMovies().First(x => x.Id == Id));
        }

        private  IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie()
                {
                    Id = 1, Name = "Érick"
                },
                new Movie()
                {
                    Id = 2, Name = "Xuxu"
                }
            };
        }

    }
}