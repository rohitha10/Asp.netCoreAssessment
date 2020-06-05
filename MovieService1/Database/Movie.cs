using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieService1.Database
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public float Budget { get; set; }

        public DateTime DateOfLaunch { get; set; }


    }
}
