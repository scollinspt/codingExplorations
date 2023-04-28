﻿using System;

namespace Exercise8
{
    /// <summary>
    /// Exercise 8 solution
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates rolling and using two dice
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // initialize random number generator
            RandomNumberGenerator.Initialize();

            // create two dice

            Die die1 = new Die();
            Die die2 = new Die();

            // tell the dice to roll themselves

            die1.Roll();
            die2.Roll();
            int sum = die1.TopSide + die2.TopSide;

            // print the top sides and the sum of the dice

            Console.WriteLine("Die 1 = " + die1.TopSide);
            Console.WriteLine("Die 2 = " + die2.TopSide);
            Console.WriteLine();
            //Console.WriteLine("Sum of both dice = " + ((int)die1.TopSide + (int)die2.TopSide));
            Console.WriteLine("Sum of both dice = " + sum);
        }
    }
}
