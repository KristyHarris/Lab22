using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab22.Models
{
    public class Movie
    {
        public Movie(string title, string genre)
        {
            Title = title;
            Genre = genre;
           
        }

        public string Title { get; set; }

        public string Genre { get; set; }
      
  
    }
}

