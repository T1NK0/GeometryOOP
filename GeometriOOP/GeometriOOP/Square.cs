using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriOOP
{
    public class Square
    {
        #region Opgave a
        private double side; //Declares the variable side, which is the sides of our square, since they are all the same length we only need 1.

        public double Side //Makes our side variable changeable.
        {
            get { return side; }
            set { side = value; }
        }

        //public Square(double squareSide) //Creates our constructor
        //{
        //    side = squareSide; //Sets the "side" value to the user input we send over from the program.cs
        //}

        public double PerimiterCalculator() //Creates a method that allows us to calculate the Perimeter of the square called "PerimiterCalculator".
        {
            return side * 4; //Returns the result of our side * 4 which will give the Perimiter.
        }

        public double AreaCalculator() //Creates a method that allows us to calculate the area of the square called "AreaCalculator"
        {
            return side * 2; //Returns the value of the area by saying side * 2 since the side is the same all around.
        }
        #endregion

        #region Opgave b
        public Square() //Creates the empty constructor without any parameters
        {

        }
        #endregion

    }
}
