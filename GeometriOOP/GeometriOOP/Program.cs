
using System;

namespace GeometriOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Opgave a
            //Console.WriteLine("Indtast sidelængde for første kvadrat i cm: "); //Asks user to insert the first squares side length.
            //double square1SideLength = double.Parse(Console.ReadLine()); //Sets the square1SideLength to the user input

            //Square square1 = new Square(square1SideLength); //Creates our square1 object and sends the value the user inputted in the int square1SideLength with as the value.
            //Console.WriteLine("Omkredsen af første kvadrat er: " + square1.PerimiterCalculator() + "cm"); //Writes the Perimeter of the square out to the console, by calling our PerimiterCalculator method in the console.writeline.
            //Console.WriteLine("Arealet af første kvadrat er: " + square1.AreaCalculator() + "cm2");

            //Console.WriteLine();

            //Console.WriteLine("Indtast sidelængde for anden kvadrat i cm: ");
            //double square2SideLength = double.Parse(Console.ReadLine());

            //Square square2 = new Square(square2SideLength);
            //Console.WriteLine("Omkredsen af anden kvadrat er: " + square2.PerimiterCalculator() + "cm");
            //Console.WriteLine("Arealet af første kvadrat er: " + square2.AreaCalculator() + "cm2");

            //Console.WriteLine();

            //Console.WriteLine("Indtast sidelængde for tredje kvadrat i cm: ");
            //double square3SideLength = double.Parse(Console.ReadLine());

            //Square square3 = new Square(square3SideLength);
            //Console.WriteLine("Omkredsen af tredje kvadrat er: " + square3.PerimiterCalculator() + "cm");
            //Console.WriteLine("Arealet af første kvadrat er: " + square3.AreaCalculator() + "cm2");
            #endregion

            #region Opgave b
            Square square4 = new Square();
            square4.Side = 24.3;

            Console.WriteLine("Side længde: " + square4.Side);
            Console.WriteLine("Omkreds: " + square4.PerimiterCalculator());
            Console.WriteLine("Areal: " + square4.AreaCalculator());
            #endregion
        }
    }
}
