using System;
using System.Collections.Generic;

namespace MVC_Countries_Lab
{
    public class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors { get; set; }
        
        public Country(string Name, string Continent, List<string> Colors)
        {
            this.Name = Name;
            this.Continent = Continent;
            this.Colors = Colors;
        }
    }
}
