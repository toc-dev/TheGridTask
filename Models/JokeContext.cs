using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGridTask.Console.Models
{
    public class JokeContext : DbContext
    {
        public JokeContext():base()
        {

        }
        public JokeContext(DbContextOptions<JokeContext> options) : base(options)
        {

        }
        public DbSet<Joke> Jokes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var connectionString = ConfigurationManager.ConnectionStrings["GridJokesDB"].ConnectionString;
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer(connectionString);
            //}
        }
    }
}
