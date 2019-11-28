using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsApp.Core.Models
{
    public partial class Movies
    {
        public long Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public List<MoviesDetails> Results { get; set; }
    }

    public partial class MoviesDetails
    {
        public string Title { get; set; }
        public long Episode_Id { get; set; }
        public string Opening_Crawl { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public DateTimeOffset Release_Date { get; set; }
        //public Uri[] Characters { get; set; }
        //public Uri[] Planets { get; set; }
        //public Uri[] Starships { get; set; }
        //public Uri[] Vehicles { get; set; }
        //public Uri[] Species { get; set; }
        //public DateTimeOffset Created { get; set; }
        //public DateTimeOffset Edited { get; set; }
        //public Uri Url { get; set; }
    }
}
