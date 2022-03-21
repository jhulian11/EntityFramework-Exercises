using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy_CodeFirst
{
    public enum Classification : byte
    {
        Silver = 1,
        Gold = 2,
        Platinum = 3
    }
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public  Genre Genreld { get; set; }

        public int Genreldd { get; set; }

        public  Classification Classification { get; set; }

        public  ICollection<Tag> Tags { get; set; }

        public Video()
        {
            Tags = new HashSet<Tag>();
        }
    }
}
