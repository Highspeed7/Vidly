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
        // GET: Movies
        public ActionResult Random()
        {

            var movies = GetAllMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetAllMovies()
        {
            return new List<Movie>
            {
                new Movie() {id = 1, Name = "Red Dawn"},
                new Movie() {id = 2, Name = "Goosebumps"},
                new Movie() {id = 3, Name = "Shrek"}
            };
        }
    }
}