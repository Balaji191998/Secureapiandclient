using movies.cleint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movies.cleint.Apimodels
{
    public class Moviesservvices:IMoviesservices
    {


        public async Task<IEnumerable<Movies>> GetCustomers()
        {
            var movielist = new List<Movies>();
            movielist.Add(
                new Movies
                {
                    Id = 1,
                    Genere = "Romantic",
                    Title = "Remo",
                    Releasedate=DateTime.Now,
                    Owner="24studios"
                }
                );
            return await Task.FromResult(movielist);

        }
        public async Task<Movies> GetCustomer(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<Movies> CreateCustomer(Movies customer)
        {
            throw new NotImplementedException();

        }
        public async Task<Movies> UpdateCustomer(Movies customer)
        {
            throw new NotImplementedException();
        }
        public async Task DeleteCustomer(int id)
        {
            throw new NotImplementedException();

        }

    }
}
