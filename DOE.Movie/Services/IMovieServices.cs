using DOE.Movie.Entities;

namespace DOE.Movie.Services
{
    public interface IMovieServices
    {
        public List<MovieModel> AllMovies();
        public MovieModel GetMovieById(string id);

        public MovieModel CreateMovie(MovieDTO Request);
    }
}