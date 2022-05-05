
Console.WriteLine("Enter the co-ordinates of the line");
Console.WriteLine("Enter the first co-ordinate");
Console.Write("Enter value of x1 : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter value of y1 : ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second co-ordinate");
Console.Write("Enter value of x2 : ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter value of y2 : ");
int y2 = Convert.ToInt32(Console.ReadLine());
double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("Length of the line is : " + length);