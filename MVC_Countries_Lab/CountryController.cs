using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Countries_Lab
{
    public class CountryController
    {
        List<Country> CountryDb { get; set; } = new List<Country>();

        public CountryController(List<Country> CountryDb)

        {
            this.CountryDb = CountryDb;

            //List<string> usaColors = new List<string> { "red", "blue", "white" };
            //Country usa = new Country("USA", "North America", usaColors);
            //CountryDb.Add(usa);

            //List<string> canadaColors = new List<string> { "red", "white" };
            //Country canada = new Country("Canada", "North America", canadaColors);
            //CountryDb.Add(canada);

        }



        public void CountryAction(Country c)
        {
            CountryView cdisplay = new CountryView(c);
            Console.Clear();
            cdisplay.Display();
        }

        public void WelcomeAction()
        {
            CountryListView cListView = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            
            bool goOn = true;
            while (goOn == true)
            {
                cListView.Display();
                CountryAction(CountryDb[GetInteger()]);
                goOn=GetContinue();
            }
            

        }

    

        public static int GetInteger()
        {
            string input = Console.ReadLine();
            int output = 0;
            try
            {
               
               output = int.Parse(input);

                if (output > 9 || output < 0)
                {
                   
                    throw new Exception("That number is out of range. Try again.");
                    
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("That was not a valid input.");
                output = GetInteger();
            }
           
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                output = GetInteger();
            }
            return output;
        }

        public static bool GetContinue()
        {

            Console.WriteLine(" ");
            Console.WriteLine("Would you like to learn about another country? y/n");
            string answer = Console.ReadLine();


            if (answer == "y")
            {
                Console.Clear();
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again");
                //Calling a method inside itself is called recursion
                //Think of this as just trying again 
                return GetContinue();
            }
        }
    }
}
