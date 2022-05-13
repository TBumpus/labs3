using Microsoft.AspNetCore.Mvc;
using OMDBLab.Models;

namespace OMDBLab.Controllers
{
    public class IMDBController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //the first method shows a blank form
        public async Task<ActionResult> MovieSearch()
        {
            return View();
        }

        //this action occurs when they hit the submit button
        [HttpPost]
        public async Task<IActionResult> MovieSearch(MovieSearch title)
        {
            //Search for the movie
            var response = await SearchMovie(title.SearchTerm);
            
            return RedirectToAction("SearchExample", response);
        }

        public async Task<IActionResult> SearchExample(IMDBResponse movieResponse)
        {
            return View(movieResponse);
        }

        public async Task<IMDBResponse> SearchMovie(string searchTerm)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://www.omdbapi.com");//would normally be in appsettings         
            
            var response = await client.GetFromJsonAsync<IMDBResponse>("?t=" + searchTerm + "&apiKey=e06364e");

            return response;
        }

        public async Task<IActionResult> MovieNight()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MovieNightList(MovieNight movieNight)
        {
            List<IMDBResponse> movieList = new List<IMDBResponse>();
            movieList.Add(await SearchMovie(movieNight.Movie1));
            movieList.Add(await SearchMovie(movieNight.Movie2));
            movieList.Add(await SearchMovie(movieNight.Movie3));

            return View(movieList);
        }

        //public async Task<IActionResult> MovieNightList(List<IMDBResponse> movies)
        //{
        //    return View(movies);
        //}
    }
}
