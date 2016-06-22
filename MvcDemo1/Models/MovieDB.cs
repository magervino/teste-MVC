using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcDemo1.Models
{
    public class MovieDB
    {
        public int id { get; set; }
        public string title { get; set; }
        public string director { get; set; }
        public DateTime date { get; set; }
    }

    public class MovieDBContext : DbContext {
        public DbSet<MovieDB> Movies { get; set; }
    }
}