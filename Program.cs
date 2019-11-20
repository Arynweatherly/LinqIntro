using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a variable thats going to hold a bunch of numbers 
            List<int> numbers = new List<int>()
            {
                10,
                11,
                34,
                99,
                45,
                15,
                56,
                72,
                91
            };

            //going to use the equivalent of filter ... it's where
            //what does filter take as a parameter in javascript.. arrow function

            //want numbers above 50

            List<int> numbersAbove50 = numbers.Where(num =>
            {
                return num > 50;
            }).ToList();

            //lets get all of the even numbers

            List<int> evenNumbers = numbers.Where(num =>
            {
                //this needs to return a boolean
                bool isEven = num % 2 == 0;
                return isEven; //now it returns a boolean
            }).ToList();

            //How can we filter the array? less than 50
            //where using a single line fat arrow function.
            //same as Js, this has an implicit return
            List<int> numebrsLessThan50 = numbers.Where(num => num < 50).ToList(); //the num before the fat arrow is taco

            //select is the equivalent of map in JS
            //callback function that gets passed back into map method in JS.. takes a single number and returns whatever you want 
            List<string> messages = numbers.Select(num =>
            {
                return $"The number is {num}";
            }).ToList();

            City nashville = new City()
            {
                Name = "Nashville"
            };

            nashville.Buildings.Add(new Building()
            {
                Name = "NSS Building",
                    Stories = 5,
                    Address = "301 Plus Park Blvd"
            });

            nashville.Buildings.Add(new Building()
            {
                Name = "TPAC",
                    Stories = 23,
                    Address = "505 Deaderick Street"
            });

            nashville.Buildings.Add(new Building()
            {
                Name = "1505",
                    Stories = 6,
                    Address = "1505 Demonbreun Street"
            });

            nashville.Buildings.Add(new Building()
            {
                Name = "The Frist",
                    Stories = 3,
                    Address = "919 Broadway"
            });

            nashville.Buildings.Add(new Building()
            {
                Name = "The Batman Building",
                    Stories = 33,
                    Address = "333 Commerce Street"
            });

            //better example for Where and Select
            //find only the buildings that haveless than 10 stories?
            List<Building> shortBuildings = nashville.Buildings.Where(Building =>
            {
                bool isShort = Building.Stories < 10;
                return isShort;
            }).ToList();

            List<string> nashvilleAddresses = nashville.Buildings.
            Select(building => building.Address).ToList();

            //select is equivalent of map so want string back

            //Aggregation method
            int sum = numbers.Sum();
            double average = numbers.Average();
        }
    }
}