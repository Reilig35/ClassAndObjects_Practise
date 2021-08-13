using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObjects_Practise
{
    class Country
    {
        public Country()
        {
            string Name = "Ireland";
            string Capital = "Dublin";
            int Population;
            string primaryLanguage = "English";
            string secondaryLanguage = "Irish";
            string largestRegion = "Cork";
        }


        public string Name {get; set;}
        public string Capital {get; set;}
        public string primaryLanguage{get; set;}
        public string secondaryLanguage {get; set;}
        public string largestRegion {get; set;}
        public int Population {get; set;}
    }
}
