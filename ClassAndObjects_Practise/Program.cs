using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            fOneCar Ferrari = new fOneCar();
            Ferrari.Name = "Ferrari";
            Ferrari.Active = false;
            Ferrari.Color = "Red";
            Ferrari.Country = "Italy";
            Ferrari.Titles = 12;

            Driver Schumacher = new Driver();
            Schumacher.Active = true;
            Schumacher.carNo = "1";
            Schumacher.Country = "Germany";
            Schumacher.Name = "Michael Schumacher";
            Schumacher.Titles = 7;
            Schumacher.Team = "Ferrari";

            {
                if (Ferrari.Active == true && Schumacher.Team == "Ferrari" && Schumacher.Active == true) 
                {
                    Console.WriteLine($"Ferrari are based in {Ferrari.Country} " +
                        $"and have racing legend {Schumacher.Name} racing for them and he's won {Schumacher.Titles} titles in F1");
                }
                else if (Ferrari.Active == true && Schumacher.Team == "Ferrari" && Schumacher.Active == false)
                {
                    Console.WriteLine($"Ferrari are based in {Ferrari.Country} " +
                        $"and had the legend {Schumacher.Name} race for them until " +
                        $"he left in 2006 with {Schumacher.Titles} titles for Michael and " +
                        $"{Ferrari.Titles} titles for Ferrari");
                }
                else if (Ferrari.Active == false && Schumacher.Team == "Ferrari" && Schumacher.Active == true)
                {
                    Console.WriteLine($"Ferrari are based in {Ferrari.Country} " +
                        $"and had the legend {Schumacher.Name} race for them until " +
                        $"Ferrai left in 2020 with {Schumacher.Titles} titles for Michael and " +
                        $"{Ferrari.Titles} titles for Ferrari");
                }
            }
            //fOneCar BAR = new fOneCar();
            //BAR.Color = "White";
            //BAR.Country = "England";
            //BAR.Active = false;
            //BAR.Titles = 0;
            
            //if (BAR.Active == true)
            //{
            //    Console.WriteLine($"BAR are based in {BAR.Country} " +
            //        $"and are currently active in F1");
            //}
            //else if (BAR.Active == false)
            //{
            //    Console.WriteLine($"BAR are based in {BAR.Country} " +
            //        $"and are no longer active in F1");
            //}
        }
    }
}
