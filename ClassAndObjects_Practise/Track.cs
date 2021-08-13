using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObjects_Practise
{
    class Track
    {
        public Track()
        {
            string Name;
            string Country;
            string Type;
            string Month;
            string Series;
            string Event;
            bool isON;
            float tLength;
        }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Type { get; set; }
        public string Month { get; set; }
        public string Series { get; set; }
        public string Event { get; set; }
        public bool isON { get; set; }
        public float tLength { get; set; }
    }
}
