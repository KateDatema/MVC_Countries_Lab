using System;
using System.Collections.Generic;

namespace MVC_Countries_Lab
{
    public class CountryController
    {
        List<Country> CountryDb { get; set; } = new List<Country>();

        public CountryController()
        {
            List<string> usaColors = new List<string> { "red", "blue", "white" };
            Country usa = new Country("USA", "North America", usaColors);
            CountryDb.Add(usa);

            List<string> canadaColors = new List<string> { "red", "white" };
            Country canada = new Country("canada", "North America", canadaColors);
            CountryDb.Add(canada);

        }

        public void CountryAction(Country c)
        {
            CountryView cdisplay = new CountryView(c);
            cdisplay.Display();
        }

        public void WelcomeAction()
        {
            CountryListView cListView = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            cListView.Display(CountryDb);
            string userInput = Console.ReadLine();

            int cNum = int.Parse(userInput);
            Country c = CountryDb[cNum];
            CountryAction(c);
            Console.WriteLine("Would you like to learn about another Country?");

        }
    }
}
