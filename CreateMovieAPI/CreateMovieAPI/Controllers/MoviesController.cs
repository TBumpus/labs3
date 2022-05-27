using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CreateMovieAPI.Data;
using CreateMovieAPI.Models;

namespace CreateMovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieDbContext _context;

        public MoviesController(MovieDbContext context)
        {
            _context = context;
        }

        
        //REQUIREMENT 1
        [HttpGet("GetMovieList")]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
          if (_context.Movies == null)
          {
              return NotFound();
          }
            return await _context.Movies.ToListAsync();
        }

        //REQUIREMENT 2
        [HttpGet("GetListByGenre")]
        public async Task<ActionResult<IEnumerable<Movie>>> GetListByGenre(string genre)
        {
          if (_context.Movies == null)
          {
              return NotFound();
          }

            return await _context.Movies.Where(x => x.Genre.Contains(genre)).ToListAsync();
        }

        //REQUIREMENT 3    
        [HttpGet("GetRandomMovie")]
        public async Task<ActionResult<Movie>> GetRandomMovie()
        {
            Random rand = new Random();           
            int randomMovie = rand.Next(0, _context.Movies.Count());

            return _context.Movies.Skip(randomMovie).Take(1).First();
        }

        //REQUIREMENT 4
        [HttpGet("GetRandomByGenre")]
        public async Task<ActionResult<Movie>> GetRandomByGenre(string genre)
        {
            Random rand = new Random();
            int randomMovie = rand.Next(0, _context.Movies.Count());
            return _context.Movies.Where(x => x.Genre == genre).Skip(randomMovie).Take(1).First();
        }

        //REQUIREMENT 5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            if (_context.Movies == null)
            {
                return NotFound();
            }
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieExists(int id)
        {
            return (_context.Movies?.Any(e => e.MovieId == id)).GetValueOrDefault();
        }
    }
}
