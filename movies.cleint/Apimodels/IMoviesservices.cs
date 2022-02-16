using movies.cleint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movies.cleint.Apimodels
{
    public interface IMoviesservices
    {
        Task<IEnumerable<Movies>> GetCustomers();
        Task<Movies> GetCustomer(int id);
        Task<Movies> CreateCustomer(Movies customer);
        Task<Movies> UpdateCustomer(Movies customer);
        Task DeleteCustomer(int id);
    }
}
