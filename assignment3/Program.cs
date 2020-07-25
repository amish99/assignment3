using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{ 

            class Program
            {
            //amish tangri -
            //Assignment 3 -
            //24/07/2020
            //301108446
            
            static void WaitForAnyKey()
            {
                Console.ReadKey();
            }
            static void Main(string[] args)
            {
            // Instantiate GiantPlanet object
            GiantPlanet giantPlanet = new GiantPlanet("venus", 12641, 4.47600000, "Ice");
                Console.WriteLine(giantPlanet);
            // Instantiate terrestrialplanet object
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12.742, 5.972, true);
                Console.WriteLine(terrestrialPlanet);

            //waiting for any key
            Program.WaitForAnyKey();

            }
        }
    }



