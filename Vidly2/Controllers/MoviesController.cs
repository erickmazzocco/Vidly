using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly2.Models;
using Vidly2.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            return View();
        }

        public ActionResult Edit(int Id)
        {
            var movie = _context.Movie.Include(x => x.Genre).ToList().SingleOrDefault(x => x.Id == Id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel(movie)
            {
                Genres = _context.Genres.ToList(),
            };

            return View("MovieForm", viewModel);
        }

        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movie.Add(movie);
            }
                
            else
            {
                var movieDb = _context.Movie.Single(x => x.Id == movie.Id);

                movieDb.Name = movie.Name;
                movieDb.ReleaseDate = movie.ReleaseDate;
                movieDb.DateAdded =  movie.DateAdded.Equals(DateTime.MinValue) ? DateTime.Now : movie.DateAdded;
                movieDb.NumberInStock = movie.NumberInStock;
                movieDb.GenreId = movie.GenreId;
            }

            _context.SaveChanges();

            return View("Index", _context.Movie.Include(x => x.Genre).ToList());
        }
    }
}