using System;
namespace MVC_Countries_Lab
{
    public class CountryView
    {
        public Country Country { get; set;}
        public Country DisplayCountry { get; set; }

        public CountryView(Country Country)
        {
            this.Country = DisplayCountry;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name}");
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            Console.WriteLine($"Colors: {DisplayCountry.Colors}");

        }

    }
}
