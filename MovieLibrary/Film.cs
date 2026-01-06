using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary
{
    public class Film : IFilm
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
    }
}
