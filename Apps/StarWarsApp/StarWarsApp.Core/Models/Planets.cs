using System;
using System.Collections.Generic;
using System.Text;

namespace StarWarsApp.Core.Models
{
    public partial class Planets
    {
        public long Count { get; set; }
        public object Next { get; set; }
        public object Previous { get; set; }
        public List<PlanetsDetails> Results { get; set; }
    }

    public partial class PlanetsDetails
    {
        public string Name { get; set; }
        public string Rotation_Period { get; set; }
        public string Orbital_Period { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        public string Surface_Water { get; set; }
        public string Population { get; set; }
        //public Uri[] Residents { get; set; }
        //public Uri[] Films { get; set; }
        //public DateTimeOffset Created { get; set; }
        //public DateTimeOffset Edited { get; set; }
        //public Uri Url { get; set; }
    }
}
