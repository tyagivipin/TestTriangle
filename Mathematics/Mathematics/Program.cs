﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mathematics
{
   public class Trigonometric  
    {
        //public  variables
        public static double eqSide1, eqSide2, eqSide3;

        public static void TrianlgeSidesInput(double side1, double side2, double side3)
        {
            string TriangleType = "";
            if ((side1 == side2) && (side1 == side3))
            {
                TriangleType = "Equilateral";
            }
            else if ((side1 == side2) || (side1 == side3) || (side2 == side3))
            {
                TriangleType = "Isosceles";
                eqSide1 = side1; eqSide2 = side2; eqSide3 = side3;
            }
            else
            {
                TriangleType = "Scalene";
            }



            switch (TriangleType)
            {
                case "Equilateral":
                    Console.WriteLine("It is Equilateral Traingle ! Reason: It's all sides are equal.\n\n\t i. e. {0}=={1}=={2}", side1, side2, side3);
                    Console.WriteLine("For Next : Press Enter \n");

                    break;

                case "Isosceles":
                    Console.WriteLine("It is Isosceles Traingle ! Reason: It's two sides are equal.");
                    Console.WriteLine("For Next : Press Enter \n");
                    break;

                case "Scalene":
                    Console.WriteLine("It is Scalene Traingle ! Reason: It's all sides have different lenght !!");
                    Console.WriteLine("For Next : Press Enter \n");
                    break;

                default:
                    Console.WriteLine("Sorry ! Try Again !");
                    break;
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Triangle Type Test :-\n----------------------------\n\n");

            Trigonometric.TrianlgeSidesInput(12, 12, 12);
            Console.ReadLine();

            Trigonometric.TrianlgeSidesInput(12, 12, 15);
            Console.ReadLine();

            Trigonometric.TrianlgeSidesInput(12, 20, 25);
            Console.ReadLine();
        }
    }
}
