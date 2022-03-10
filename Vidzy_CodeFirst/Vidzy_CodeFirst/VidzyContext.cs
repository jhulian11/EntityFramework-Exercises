using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Vidzy_CodeFirst.EntityConfigurations;

namespace Vidzy_CodeFirst
{
    public class VidzyContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public VidzyContext()
            : base("name = VidzyContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VideoConfiguration());
            modelBuilder.Configurations.Add(new GenreConfiguration());
            modelBuilder.Configurations.Add(new TagConfiguration());


            base.OnModelCreating(modelBuilder);

        }
    }
}
