using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Vidzy_CodeFirst.Exercises
{
    class Exercise_LoadingRelatedObjects
    {
        public static void Exercise()
        {
            var context = new VidzyContext();

            // Lazy Loading
            // Just put the Navegation Property as virtual, in this case put "Genreld" as virtual, in the Videos Table Class 

            // Eager Loading
            //var videos = context.Videos.Include(v => v.Genreld).ToList();

            // Explicit Loading

            var videos = context.Videos.ToList();
            context.Genres.Load();


            foreach (var video in videos)
            {
                Console.WriteLine("{0}  {1}",video.Name,video.Genreld.Name);
            }

        }
    }
}
