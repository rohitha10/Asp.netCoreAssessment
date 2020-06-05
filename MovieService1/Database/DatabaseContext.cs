using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieService1.Database
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Movie> movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-NKEA76K\SQLEXPRESS; initial catalog=MovieMicroservice; persist security info=True;user id=sa;password=password-1;");
        }
    }
}
