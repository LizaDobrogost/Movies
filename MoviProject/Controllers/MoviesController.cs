using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviProject.Models;
using MoviProject.ViewModels;

namespace MoviProject.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var viewResul=new  ViewResult();
            var customer=new List<Customer>()
            {
                new Customer(){Name = "John Smith"},
                new Customer(){Name ="Mary Wiliams"}
            };
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customer
            };
            return View(viewModel);
        }
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year+"/"+month);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortby{1}", pageIndex, sortBy));
        }
    }
}