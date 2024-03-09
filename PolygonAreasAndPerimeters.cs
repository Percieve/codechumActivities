using System;

public interface PolygonInterface
{
    double GetArea();
    double GetPerimeter();
}

public class Square : PolygonInterface
{
    private double side;
    
    public Square(double side)
    {
        this.side = side;
    }
    public double GetArea()
    {
        return side * side;
    }
    public double GetPerimeter()
    {
        return 4 * side;
    }
}

public class Rectangle : PolygonInterface
{
    private double length;
    private double width;
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double GetArea()
    {
        return length * width;
    }

    public double GetPerimeter()
    {
        return 2 * (length + width);
    }
}

public class Trapezoid : PolygonInterface
{
    private double a;
    private double b;
    private double c;
    private double d;
    private double height;

    public Trapezoid(double a, double b, double c, double d, double height)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
        this.height = height;
    }

    public double GetArea()
    {
        return ((a + b) / 2) * height;
    }

    public double GetPerimeter()
    {
        return a + b + c + d;
    }
}
