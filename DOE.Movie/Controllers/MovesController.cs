using DOE.Movie.Entities;
using DOE.Movie.Services;
using Microsoft.AspNetCore.Mvc;

namespace DOE.Movie.Controllers
{
    [ApiController]
    [Route("Movies")]
    public class MovesController : ControllerBase
    {
        private readonly IMovieServices _movieServices;

        public MovesController(IMovieServices movieServices)
        {
            _movieServices = movieServices;
        }

        [HttpGet("All")]
        public ActionResult GetMovies()
        {
            return Ok(_movieServices.AllMovies());
        }

        [HttpGet("{id}")]
        public ActionResult GetMovie(string id)
        {
            return Ok(_movieServices.GetMovieById(id));
        }

        [HttpPost("Create")]
        public ActionResult CreateMovie(MovieDTO request)
        {
            return Ok(_movieServices.CreateMovie(request));
        }
    }
}
