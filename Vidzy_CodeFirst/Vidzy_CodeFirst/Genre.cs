﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace Vidzy_CodeFirst
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Video> Video { get; set; }

        public Genre()
        {
            Video = new Collection<Video>();
        }
    }
}
