using System.Collections.Generic;

namespace GenericRepository.Movie
{
    public interface IMovieRepository : IRepository<MovieModel>
    {
        IEnumerable<MovieModel> FindByTitle(string title);
    }
}
