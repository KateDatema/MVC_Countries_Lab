using System;
using System.Collections.Generic;
using System.IO;

namespace MVC_Countries_Lab
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Country> ourCountryList = new List<Country>(ReadinList());
            CountryController ourCountrys = new CountryController(ourCountryList);
            ourCountrys.WelcomeAction();
          
        }

        public static List<Country> ReadinList()
        {
            string filePath = @"/Users/katedatema/Projects/MVC_Countries_Lab/MVC_Countries_Lab/Countrys.txt";

            // pulling in the info from student.txt document
            StreamReader reader = new StreamReader(filePath);
            string output = reader.ReadToEnd();
            reader.Close();

            // splitting each line and putting them in a list
            string[] lines = output.Split('\n');

            //creating a list to store objects 
            List<Country> loadedCountry = new List<Country>();

            //adding country objects to a list 
            foreach (string line in lines)
            {
                Country country = ConvertToCountryObj(line);
                if (country != null)
                {
                    loadedCountry.Add(country);
                }
            }
            return loadedCountry;
        }

        public static Country ConvertToCountryObj(string line)
        {
            string[] properties = line.Split(',');
            List<string> colors = new List<string>();
            Country countryObj = new Country("null", "null", colors);
            List<string> countryColors = new List<string>();
            
            if (properties.Length == 3)
            {
                countryObj.Name = properties[0].Trim(); ;
                countryObj.Continent = properties[1].Trim();
                string[] colorProperties = properties[2].Split(' ');
                
                for (int i = 0; i< colorProperties.Length; i++)
                {
                    countryColors.Add(colorProperties[i]);
                    
                }

                countryObj.Colors = countryColors;
                return countryObj;
            }
            else
            {
                return null;
            }
        }

    }
}
