using Microsoft.AspNetCore.Mvc;
using JurnalModul9_2311104079.Models;
using System.Collections.Generic;

namespace JurnalModul9_2311104079.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> Movies = new List<Movie>
        {
            new Movie
            {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> { "Tim Robbins", "Morgan Freeman" },
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."
            },
            new Movie
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string> { "Marlon Brando", "Al Pacino" },
                Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."
            },
            new Movie
            {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string> { "Christian Bale", "Heath Ledger" },
                Description = "When the menace known as the Joker emerges, Batman must accept one of the greatest psychological and physical tests."
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            return Ok(Movies);
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovie(int id)
        {
            if (id < 0 || id >= Movies.Count)
            {
                return NotFound();
            }
            return Ok(Movies[id]);
        }

        [HttpPost]
        public ActionResult<Movie> AddMovie([FromBody] Movie movie)
        {
            Movies.Add(movie);
            return CreatedAtAction(nameof(GetMovie), new { id = Movies.Count - 1 }, movie);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            if (id < 0 || id >= Movies.Count)
            {
                return NotFound();
            }
            Movies.RemoveAt(id);
            return NoContent();
        }
    }
}
