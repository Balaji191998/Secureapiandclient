using moviesapi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace moviesapi.Data
{
    public class Moviescontextseed
    {
        public static void SeedAsync(moviesapiContext apicontext)
        {
            if(!apicontext.Movies.Any())
            {
                var movies = new List<Movies>
                {
                    new Movies
                    {
                        Id=1,
                        Genere="Drama",
                        Title="The shawshank Redemption",
                        Releasedate=new DateTime(1994,5,5),
                        Owner="alice"
                    },
                    new Movies
                    {
                         Id=2,
                        Genere="crime",
                        Title="The Godfather",
                        Releasedate=new DateTime(2000,5,5),
                        Owner="alice"
                    }
                };
                apicontext.Movies.AddRange(movies);
                apicontext.SaveChanges();
            }
        }
    }
}
