﻿using System;
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

        }
    }
}