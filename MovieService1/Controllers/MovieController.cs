using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieService1.Database;

namespace MovieService1.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        DatabaseContext _db;
        public MovieController()
        {
            _db = new DatabaseContext();
        }
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _db.movies.ToList();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Movie model)
        {
            _db.movies.Add(model);
            _db.SaveChanges();
            return Ok("new record added");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Movie model)
        {
            var existingMovie = _db.movies.Where(m => m.Id == id).FirstOrDefault();
            existingMovie.Title = model.Title;
            existingMovie.Budget = model.Budget;
            existingMovie.DateOfLaunch = model.DateOfLaunch;
            _db.movies.Update(existingMovie);
            _db.SaveChanges();
            return Ok("Updated");
           

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var movie = _db.movies.Where(m => m.Id == id).FirstOrDefault();
            _db.movies.Remove(movie);
            _db.SaveChanges();
            return Ok("deleted");
        }



    }
}