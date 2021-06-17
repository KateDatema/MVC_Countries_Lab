using System;

namespace MVC_Countries_Lab
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CountryController cc = new CountryController();
            cc.WelcomeAction();
        }

        
    }
}
