using GenericRepository.Movie;
using System;

namespace GenericRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovieRepository repository = new MovieRepository();
            repository.Add(new MovieModel { Id = 1, Category = CategoryEnum.CLASSIC, Title = "The man" });
            repository.Add(new MovieModel { Id = 2, Category = CategoryEnum.ACTION, Title = "Batman Begins" });
            repository.Add(new MovieModel { Id = 3, Category = CategoryEnum.THRILLER, Title = "2:22" });

            //var list = repository.GetAll();

            var list = repository.FindByTitle("ma");

            foreach (MovieModel b in list)
            {
                Console.WriteLine(string.Format(
                    "#{0} | Category: {1} | Title: {2}", b.Id, b.Category, b.Title
                ));
            }
            
            Console.ReadKey();
        }
    }
}
