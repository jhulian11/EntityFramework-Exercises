using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace Vidzy_CodeFirst.EntityConfigurations
{
    class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            Property(v => v.Name)
                .IsRequired()
                .HasMaxLength(255);

            HasRequired(v => v.Genreld)
                .WithMany(g => g.Video)
                .HasForeignKey(v => v.Genreldd)
                .WillCascadeOnDelete(false);

            HasMany(v => v.Tags)
                .WithMany(t => t.Videos)
                .Map(m => 
                {
                    m.ToTable("VideoTags");
                    m.MapLeftKey("VideoId");
                    m.MapRightKey("TagId");

                });
         
        }
    }
}
