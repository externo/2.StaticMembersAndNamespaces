using System;
class Program
{
    static void Main(string[] args)
    {
        //////////////////////---HERE STARTS PROBLEM 1---//////////////////////////
        Console.WriteLine();
        Console.WriteLine("---HERE STARTS PROBLEM 1---");
        Point3D p1 = new Point3D(1, 2, 3);
        p1.ToString();
        Point3D p2 = Point3D.StartingPoint;
        //////////////////////---HERE STARTS PROBLEM 2---//////////////////////////
        Console.WriteLine();
        Console.WriteLine("---HERE STARTS PROBLEM 2---");
        double d1 = DistanceCalculator.Calculate(p1, p2);
        Point3D p3 = new Point3D(5, 2, 99);
        double d2 = DistanceCalculator.Calculate(p1, p3);
        Console.WriteLine(d1+ "      "+d2);
    }
}