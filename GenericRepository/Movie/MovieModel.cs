namespace GenericRepository.Movie
{
    public class MovieModel
    {
        public MovieModel() { }
        public int Id { get; set; }
        public string Title { get; set; }
        public CategoryEnum Category { get; set; }
    }
}
