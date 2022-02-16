using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movies.cleint.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genere { get; set; }
        public DateTime Releasedate { get; set; }
        public string Owner { get; set; }
    }
}
