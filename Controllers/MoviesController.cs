using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JurnalModul9_103082400004.Models;

namespace JurnalModul9_103082400004.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string>{ "Tim Robbins", "Morgan Freeman" },
                Description = "Two imprisoned men bond over a number of years."
            },
            new Movie
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string>{ "Marlon Brando", "Al Pacino" },
                Description = "The aging patriarch of an organized crime dynasty transfers control."
            },
            new Movie
            {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string>{ "Christian Bale", "Heath Ledger" },
                Description = "Batman faces the Joker."
            }
        };

        [HttpGet]
        public IEnumerable<Movie> GetAll()
        {
            return movies;
        }

        [HttpGet("{id}")]
        public Movie GetById(int id)
        {
            return movies[id];
        }

        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            movies.Add(movie);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            movies.RemoveAt(id);
        }
    }
}

