using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace ShapeAreaCalculatorTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write subroutines to calculate the areas of 
            // Circle   pie r squared
            // Triangle     width*length /2
            // Rectangle    width * length
            // Pentagon     
            // Octagon
           
            Console.WriteLine("What would you like to find the area of(to 1 dp)? Circle[1] Triangle[2] Rectangle[3] Pentagon[4] Octagon[5]");
            int choice = Convert.ToInt16(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("What is the radius of the circle?");
                int Radius = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(areaOfCircle(Radius));
            }
            else if (choice == 2)
            {
                Console.WriteLine("What is the length of the triangle? ");
                int Length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the width of the triangle? ");
                int Width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(areaOfTriangle(Length,Width));
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the length of the rectangle? ");
                int Length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the width of the rectangle? ");
                int Width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(areaOfRectangle(Length, Width));
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the side length of the regular pentagon?");
                int LengthOfSide = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(areaOfPentagon(LengthOfSide));
            }
            else if (choice == 5)
            {
                Console.WriteLine("What is the side length of the regular octagon?");
                int LengthOfSide = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(areaOfOctagon(LengthOfSide));
            }
            else
            {
                Console.WriteLine("Option not listed");
            }
        }



        static int areaOfRectangle(int length, int width)//Add the parameters
        {
            return length * width;
        }
        static int areaOfCircle(int radius)//Add the parameters
        {
            double pI = Math.PI;
            double area = (radius * radius * pI);
            return (int)area;
        }
        static int areaOfTriangle(int length, int width)//Add the parameters
        {
            return (length * width) / 2;
        }
        static int areaOfOctagon(int lengthOfSide)//Add the parameters
        {
            double root = Math.Sqrt(2);
            return (int)(2 *(1 + root)*(lengthOfSide * lengthOfSide));
        }
        static int areaOfPentagon(int lengthOfSide)//Add the parameters
        {
            double area = Math.Sqrt(5 * (5 + 2 * (Math.Sqrt(5)))) * (lengthOfSide  * lengthOfSide) / 4;
            return (int)area;
        }
    }
}
