namespace DOE.Movie.Entities
{
    public class MovieModel
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
    }

    public class MovieDTO
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
    }
}
