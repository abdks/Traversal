using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Traversal.Areas.Admin.Models;
using System.Net.Http;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ApiMovieController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ApiMovieViewModel> apiMovies = new List<ApiMovieViewModel>();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/top32"),
                    Headers =
                    {
                       { "X-RapidAPI-Key", "7716aa210cmsh52c76252642d8a7p1e643ejsn86b396b3d32c" },
        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
                    },
                };

                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    apiMovies = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
                    return View(apiMovies);
                }
            
        
        }
    }
}
