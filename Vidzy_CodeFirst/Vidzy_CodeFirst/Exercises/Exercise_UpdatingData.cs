using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Vidzy_CodeFirst.Exercises
{
    public class Exercise_UpdatingData
    {
        public static void Exercise1(Video video) // ADD Video
        {
            using (var context = new VidzyContext())
            {
                context.Videos.Add(video);
                context.SaveChanges();
            }
        }

        public static void Exercise2(params string[] tagNames) // AddTags to Tags Table
        {
            using (var context = new VidzyContext())
            {
                foreach (var tagName in tagNames)
                {
                    if (!context.Tags.Any(t => t.Name.Equals(tagName)))
                    {
                        var newTag = new Tag
                        {
                            Name = tagName
                        };
                        context.Tags.Add(newTag);
                    }
                    else
                    {
                        Console.WriteLine("You tried to create a already existing Tag ({0}).", tagName);
                    }

                    context.SaveChanges();
                }

            }
        }

        public static void Exercise3(int videoId, params string[] tagNames) // Add a amoun of Tags from Tags Table to a Video
        {
            using (var context = new VidzyContext())
            {
                var video = context.Videos.Include(v => v.Tags).Single(v => v.Id.Equals(videoId));
                var tags = context.Tags;

                foreach (var tagName in tagNames)
                {
                    if (!tags.Any(t => t.Name.Equals(tagName)))
                    {
                        var newTag = new Tag
                        {
                            Name = tagName
                        };

                        tags.Add(newTag);   
                        context.SaveChanges();

                    }

                    if (!video.Tags.Contains(tags.Single(t => t.Name.Equals(tagName))))
                    {                    
                        video.Tags.Add(tags.Single(t => t.Name.Equals(tagName)));
                    }
                    else 
                    {
                        Console.WriteLine("Your video already have this tag ({0}).", tagName);
                    }

                    context.SaveChanges();

                }

            }
        }


        public static void Exercise4(int videoId, params string[] deleteTags)// Delete a Tag from a Video
        {
            using (var context = new VidzyContext())
            {
                var video = context.Videos.Include(v => v.Tags).Single(v => v.Id.Equals(videoId));
                var tags = context.Tags;

                foreach (var tagName in deleteTags)
                {
                    if (video.Tags.Contains(tags.Single(t => t.Name.Equals(tagName))))
                    {
                        video.Tags.Remove(tags.Single(t => t.Name.Equals(tagName)));
                    }

                    else
                        Console.WriteLine("Your Video Not Contains this Tag({})", tagName);
                }

                context.SaveChanges();
            }

        }

        public static void Exercise5(int videoId) // Delete a video
        {
            using (var context = new VidzyContext())
            {
                var video = context.Videos.Find(videoId);
                if (video == null) return;

                context.Videos.Remove(video);

                context.SaveChanges();

            }
        }

        public static void Exercise6(int genreId) // Delete a Genre and all the videos with this Gender
        {
            using (var context = new VidzyContext())
            {
                var genre = context.Genres.Include(g => g.Video).SingleOrDefault(g => g.Id.Equals(genreId));
                if (genre == null) return;

                Console.WriteLine("teste");
                context.Videos.RemoveRange(genre.Video);
                context.Genres.Remove(genre);

                context.SaveChanges();
            }
        }

   
    }
}
