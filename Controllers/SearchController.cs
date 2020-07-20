using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab22.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab22.Controllers
{
    public class SearchController : Controller
    {

        private List<Movie> _movieList = new List<Movie>
            {
                  new Movie("Moon", "Scifi"),
                  new Movie("Star Trek II : The Wrath of Khan", "Scifi"),
                  new Movie("The Matrix", "Scifi"),
                  new Movie("Ad Astra", "Scifi"),
                  new Movie("Shrek", "Animated"),
                  new Movie("Frozen", "Animated"),
                  new Movie("Finding Nemo", "Animated"),
                  new Movie("My Neighbor Totoro", "Animated"),
                  new Movie("Moonlight", "Drama"),
                  new Movie("A Beustiful Day in the Neighborhood", "Drama"),
                  new Movie("A Star is Born", "Drama"),
                  new Movie("Selma", "Drama"),
                  new Movie("The Omen", "Horror"),
                  new Movie("Holloween", "Horror"),
                  new Movie("The Exorcist", "Horror"),
                  new Movie("Scream", "Horror"),
            };

        public IActionResult Index(SearchRequest request)
        {
            return View(request);
        }
        public IActionResult Search(SearchRequest request)
        {
            return View(request);
        }
        [HttpPost]
        public IActionResult SearchResultTitle(SearchRequest request)
        {

            return View();
        }

       
        [HttpPost]
        public IActionResult SearchResultGenre(SearchRequest request)
        {
            foreach (var movie in _movieList)
                if (movie.Genre == request.Genre)
                {
                    Console.WriteLine(movie.Title);

                   
                }
           
            return View();
        }


    }
}