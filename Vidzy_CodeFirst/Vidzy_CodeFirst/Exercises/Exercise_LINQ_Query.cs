using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy_CodeFirst.Exercises
{
    public class Exercise_LINQ_Query
    {
        public static void Exercise()
        {
            // Exercises LINQ QUERY
            var context = new VidzyContext();

            // ExerciseLINQ_QUERY 1

            var query1 =
                context.Videos
                .Where(v => v.Genreldd == 1)
                .OrderBy(v => v.Name);

            //foreach (var video in query1)
            //{
            //    Console.WriteLine(video.Name);
            //}

            // ExerciseLINQ_QUERY 2

            var query2 =
                context.Videos
                .Where(v => v.Classification == Classification.Gold)
                .OrderByDescending(v => v.ReleaseDate);

            //foreach (var video in query2)
            //{
            //    Console.WriteLine(video.Name);
            //}

            // ExerciseLINQ_QUERY 3

            var query3 =
                context.Videos.Select(v => new
                {
                    MovieName = v.Name,
                    Genre = v.Genreld.Name

                });

            //foreach (var video in query3)
            //{
            //    Console.WriteLine("{0},{1}", video.MovieName, video.Genre);
            //}

            // ExerciseLINQ_QUERY 4

            var query4 =
                context.Videos
                .GroupBy(v => v.Classification)
                .Select(v => new
                {
                    Classification = v.Key.ToString(),
                    //Movies = v.Select(m => m.Name)                  
                    Movies = v.OrderBy(m => m.Name)
                });

            foreach (var group in query4)
            {
                Console.WriteLine("classification: {0}", group.Classification);
                foreach (var movie in group.Movies)
                {
                    Console.WriteLine("\t {0}", movie.Name /*movie*/);
                }
            }

            // ExerciseLINQ_QUERY 5

            var query5 =
                context.Videos
                .GroupBy(v => v.Classification)
                .Select(v => new
                {
                    Classification = v.Key.ToString(),
                    ClassificationQuantity = v.Count()
                })
                .OrderBy(v => v.Classification);

            //foreach (var group in query5)
            //{
            //    Console.WriteLine("{0} ({1})", group.Classification,group.ClassificationQuantity);
            //}

            // ExerciseLINQ_QUERY 6

            var query6 =
                context.Genres.GroupJoin(context.Videos,
                g => g.Id,
                v => v.Genreldd,
                (Genres, Video) => new
                {
                    Genre = Genres.Name,
                    VideoGenreCount = Video.Count()
                })
                .OrderByDescending(v => v.VideoGenreCount);

            //foreach (var group in query6)
            //{
            //    Console.WriteLine("{0} ({1})", group.Genre,group.VideoGenreCount);
            //}

           
        }
    }
}
