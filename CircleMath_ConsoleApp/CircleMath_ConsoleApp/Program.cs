﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleMath_ConsoleApp
{
    /// <summary>
    /// Outputs a variety of circle characteristics
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Outputs radius and area for circles with radii 0 through 5
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int radius;
            float area;

            // What follows is a mess. Its repeated code - need to rewrite using iteration 
            // circle with radius 0
            radius = 0;
            area = (float)Math.PI * radius * radius;
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}", radius, area);

            // circle with radius 1
            radius = 1;
            area = (float)Math.PI * radius * radius;
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}", radius, area);

            // circle with radius 2
            radius = 2;
            area = (float)Math.PI * radius * radius;
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}", radius, area);

            // circle with radius 3
            radius = 3;
            area = (float)Math.PI * radius * radius;
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}", radius, area);

            // circle with radius 4
            radius = 4;
            area = (float)Math.PI * radius * radius;
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}", radius, area);

            // circle with radius 5
            radius = 5;
            area = (float)Math.PI * radius * radius;
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}", radius, area);
        }
    }
}
