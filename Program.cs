using System;
using System.Collections.Generic;

namespace planet_and_spaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanetsList = new List<string>(){"Uranus", "Neptune"};

            planetList.AddRange(lastPlanetsList);

            planetList.Insert(1, "Earth");
            planetList.Insert(2, "Venus");

            planetList.Add("Pluto");

            List<string> rockyPlanets = new List<string>();

            rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");
        }
    }
}
