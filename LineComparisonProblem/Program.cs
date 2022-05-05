using System;

namespace LineComparisonProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the co-ordinates of first line");
            Console.WriteLine("Enter the first co-ordinate of the first line");
            Console.Write("Enter value of x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second co-ordinate of the first line");
            Console.Write("Enter value of x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of y2 : ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(x1,y1) = ({0},{1})\t\t(x2,y2) = ({2},{3})", x1, y1, x2, y2);
            double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of the line is : " + length1);

            Console.WriteLine("Enter the co-ordinates of second line");
            Console.WriteLine("Enter the first co-ordinate of the second line");
            Console.Write("Enter value of x3 : ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of y3 : ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second co-ordinate of the second line");
            Console.Write("Enter value of x4 : ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of y4 : ");
            int y4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(x3,y3) = ({0},{1})\t\t(x4,y4) = ({2},{3})", x3, y3, x4, y4);
            double length2 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of the line is : " + length2);
            var result = length1.Equals(length2) ? "The two lines are equal in length" : "The two lines are not equal in length";
            Console.WriteLine(result);
        }
    }
}