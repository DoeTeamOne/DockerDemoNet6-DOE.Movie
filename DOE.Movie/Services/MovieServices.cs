using DOE.Movie.Entities;

namespace DOE.Movie.Services
{
    public class MovieServices : IMovieServices
    {
        List<MovieModel> Movies = new List<MovieModel>();
        public MovieServices()
        {
            var MoviesList = new List<MovieModel>{
             new MovieModel
             {
                  ID = Guid.NewGuid().ToString(),
                  Title = "Black Panther",
                  Genre = "Action",
                   Rating = 4.5,
                    Year = "2023"
             },
             new MovieModel
             {
                  ID = Guid.NewGuid().ToString(),
                  Title = "Creed 3",
                  Genre = "Action",
                   Rating = 4.9,
                    Year = "2022"
             },
             new MovieModel
             {
                  ID = Guid.NewGuid().ToString(),
                  Title = "Infinity Pool",
                  Genre = "Action",
                   Rating = 4.3,
                    Year = "SciFic"
             }
            };
            Movies.AddRange(MoviesList);
        }
        public List<MovieModel> AllMovies()
        {
            return Movies;
        }

        public MovieModel CreateMovie(MovieDTO Request)
        {
            var NewItem = new MovieModel
            {
                ID = Guid.NewGuid().ToString(),
                Title = Request.Title,
                Genre = Request.Genre,
                Rating = Request.Rating,
                Year = Request.Year,
            };

            Movies.Add(NewItem);
            return Movies.Where(x => x.ID == NewItem.ID).First();

        }

        public MovieModel GetMovieById(string id)
        {
            return Movies.FirstOrDefault(x => x.ID == id);
        }
    }
}
