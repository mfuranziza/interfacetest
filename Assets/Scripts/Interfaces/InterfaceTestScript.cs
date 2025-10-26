using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    
    void Start()
    {
        // Test Trapezium
        Debug.Log("--- TRAPEZIUM ---");
        Trapezium trapezium = new Trapezium(10f, 6f, 5f, 5f, 4f);
        trapezium.CalculateArea();
        trapezium.CalculatePerimeter();
        trapezium.CalculateUnknownSides();
        Debug.Log("");

        // Test Circle
        Debug.Log("--- CIRCLE ---");
        Circle circle = new Circle(7f);
        circle.CalculateArea();
        circle.CalculatePerimeter();
        circle.CalculateRadius();
        Debug.Log("");

        // Test Nonagon
        Debug.Log("--- NONAGON ---");
        Nonagon nonagon = new Nonagon(5f);
        nonagon.CalculateArea();
        nonagon.CalculatePerimeter();
        int sides = nonagon.CalculateNumberOfSides();
        Debug.Log($"Number of Sides: {sides}");
        Debug.Log("");

        
    }

    void Update()
    {
    }
}


public interface IShape
{
    void CalculateArea();
    void CalculatePerimeter();
}

// Trapezium implementing IShape
public class Trapezium : IShape
{
    
    private float baseA;
    private float baseB;
    private float sideC;
    private float sideD;
    private float height;

    public Trapezium(float baseA, float baseB, float sideC, float sideD, float height)
    {
        this.baseA = baseA;
        this.baseB = baseB;
        this.sideC = sideC;
        this.sideD = sideD;
        this.height = height;
    }

    public void CalculateArea()
    {
        float area = ((baseA + baseB) / 2) * height;
        Debug.Log($"Trapezium Area: {area} square units");
    }

    public void CalculatePerimeter()
    {
        float perimeter = baseA + baseB + sideC + sideD;
        Debug.Log($"Trapezium Perimeter: {perimeter} units");
    }

    public void CalculateUnknownSides()
    {
        float unknownSide = Mathf.Sqrt(Mathf.Pow(height, 2) + Mathf.Pow((baseA - baseB) / 2, 2));
        Debug.Log($"Trapezium Calculated Unknown Side: {unknownSide:F2} units");
    }
}

// Circle implementing IShape
public class Circle : IShape
{
    
    private float radius;

    public Circle(float radius)
    {
        this.radius = radius;
    }

    public void CalculateArea()
    {
        float area = Mathf.PI * Mathf.Pow(radius, 2);
        Debug.Log($"Circle Area: {area:F2} square units");
    }

    public void CalculatePerimeter()
    {
        float perimeter = 2 * Mathf.PI * radius;
        Debug.Log($"Circle Circumference: {perimeter:F2} units");
    }

    public void CalculateRadius()
    {
        Debug.Log($"Circle Radius: {radius} units");
    }
}

// Nonagon implementing IShape
public class Nonagon : IShape
{
    private int numberOfSides = 9;
    private float sideLength;

    public Nonagon(float sideLength)
    {
        this.sideLength = sideLength;
    }

    public void CalculateArea()
    {
        float area = 6.18182f * Mathf.Pow(sideLength, 2);
        Debug.Log($"Nonagon Area: {area:F2} square units");
    }

    public void CalculatePerimeter()
    {
        float perimeter = numberOfSides * sideLength;
        Debug.Log($"Nonagon Perimeter: {perimeter} units");
    }

    public int CalculateNumberOfSides()
    {
        return numberOfSides;
    }
}