using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var vidzy = new VidzyEntities();
            var today = DateTime.Now;
            var video = new Video();

            vidzy.AddVideo("Video9",today,"Romance",(byte)Classification.Gold);

           
        }
    }
}
