using System.Collections.Generic;
namespace JurnalModul9_103082400004.Models

{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> Stars { get; set; }
        public string Description { get; set; }

        public Movie() { }
    }
}

