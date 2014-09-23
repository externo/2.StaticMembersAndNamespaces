using System;

public class Point3D
{
    //fields
    private int x;
    private int y;
    private int z;
    private static readonly Point3D startingPoint;

    //constructors
    static Point3D()
    {
        Point3D.startingPoint = new Point3D(0, 0, 0);
    }

    public Point3D(int x, int y, int z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    //properties
    public int X
    {
        get { return this.x; }
        set { this.x = value; }
    }

    public int Y
    {
        get { return this.y; }
        set { this.y = value; }
    }

    public int Z
    {
        get { return this.z; }
        set { this.z = value; }
    }

    public static Point3D StartingPoint
    {
        get { return Point3D.startingPoint; }
    }

    //methods
    public override string ToString()
    {
        string result = string.Format("X:{0}, Y:{1}, Z:{2}", this.X, this.Y, this.Z);
        Console.WriteLine(result);
        return result;
    }
}