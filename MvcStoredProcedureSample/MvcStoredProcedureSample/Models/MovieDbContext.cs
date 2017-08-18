using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcStoredProcedureSample.Models
{
    public class MovieDbContext : DbContext
    {
        
        public MovieDbContext() : base("name=MovieDbContext")
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {  
            modelBuilder.Entity<Movie>().MapToStoredProcedures();  
        }

}
}
