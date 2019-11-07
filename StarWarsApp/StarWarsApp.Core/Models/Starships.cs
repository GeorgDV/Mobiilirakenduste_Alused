using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsApp.Core.Models
{
    public partial class Starships
    {
        public long Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public List<StarshipsDetails> Results { get; set; }
    }

    public partial class StarshipsDetails
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public long Cost_In_Credits { get; set; }
        public long Length { get; set; }
        public string Max_Atmosphering_Speed { get; set; }
        public long Crew { get; set; }
        public long Passengers { get; set; }
        public long Cargo_Capacity { get; set; }
        public string Consumables { get; set; }
        public string Hyperdrive_Rating { get; set; }
        public long Mglt { get; set; }
        public string Starship_Class { get; set; }
        //public object[] Pilots { get; set; }
        //public Uri[] Films { get; set; }
        //public DateTimeOffset Created { get; set; }
        //public DateTimeOffset Edited { get; set; }
        //public Uri Url { get; set; }
    }
}
