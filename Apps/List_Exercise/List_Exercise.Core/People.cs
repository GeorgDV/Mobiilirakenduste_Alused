using System;
using System.Collections.Generic;
using System.Text;

namespace List_Exercise.Core
{
    public partial class People
    {
        public long Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public List<PeopleDetails> Results { get; set; }
    }

    public partial class PeopleDetails
    {
        public string Name { get; set; }
        public long Height { get; set; }
        public long Mass { get; set; }
        public string Hair_Color { get; set; }
        public string Skin_Color { get; set; }
        public string Eye_Color { get; set; }
        public string Birth_Year { get; set; }
        public string Gender { get; set; }
        //public Uri Homeworld { get; set; }
        //public Uri[] Films { get; set; }
        //public Uri[] Species { get; set; }
        //public Uri[] Vehicles { get; set; }
        //public Uri[] Starships { get; set; }
        //public DateTimeOffset Created { get; set; }
        //public DateTimeOffset Edited { get; set; }
        //public Uri Url { get; set; }
    }
}
