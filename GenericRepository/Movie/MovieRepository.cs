using System.Collections.Generic;

namespace GenericRepository.Movie
{
    public class MovieRepository : Repository<MovieModel>, IMovieRepository
    {
        public IEnumerable<MovieModel> FindByTitle(string title)
        {
            var searchTerm = title.ToLower();
            return Find(p => p.Title.ToLower().Contains(searchTerm));
        }
    }
}
