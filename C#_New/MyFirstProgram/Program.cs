// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using MyUtilities;

namespace MyFirstProgram
{
        class CheckComfort
        {
                static void Main(string[] args)
                {
                    Console.WriteLine("Where should we go in May?");
                    WeatherUtilities.Report("Sydney", WeatherUtilities.FahrenheitToCelsius(66), 30);
                    WeatherUtilities.Report("Melbourne", WeatherUtilities.FahrenheitToCelsius(65), 22);
                    WeatherUtilities.Report("Australia", 32, 40); 
                }

                static float FahrenheitToCelsius(float temperatureFahrenheit)
                {
                        var temperatureCelsius = (temperatureFahrenheit - 32) / 1.8f;
                        return temperatureCelsius;

                }
        }
}                                               