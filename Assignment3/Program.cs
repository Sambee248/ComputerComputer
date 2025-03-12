// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Text;

//接口
public interface myShape{
    double CalculateArea();   //计算面积
    bool funcCheck();    //判断形状是否合法
}

//抽象类
public abstract class Shape : myShape{
    public abstract double CalculateArea();
    public abstract bool funcCheck();

}

//长方形
public class Rectangle : Shape{
    public double Length{ get; set; }
    public double Width{ get; set; }

    // 构造函数
    public Rectangle(double length, double width){
        Length = length;
        Width = width;

    }
    
    public override double CalculateArea(){
        return Length * Width;
    }

    public override bool funcCheck(){
        return Length > 8 && Width > 0;
    }

}

//正方形
public class Square : Shape{
    public double Side { get; set; }

    public Square(double side){
        Side = side;
    }

    public override double CalculateArea(){
        return Side * Side;   
    }

    public override bool funcCheck(){
        return Side > 0;
    }
}

//三角形
public class Triangle : Shape{
    public double sideA { get; set; }
    public double sideB { get; set; }
    public double sideC { get; set; }

    public Triangle(double aSide, double bSide, double cSide){
        sideA = aSide;
        sideB = bSide;
        sideC = cSide;
    }

    public override double CalculateArea(){
        //海伦公式
        double p = (sideA + sideB + sideC) / 2;
        double square = Math.Sqrt( p * (p - sideA) * (p - sideB) * (p - sideC));
        return square;
    }

    public override bool funcCheck(){
        return sideA > 0 && sideB > 0 && sideC > 0 &&
               sideA + sideB > sideC &&
               sideB + sideC > sideA &&
               sideA + sideC > sideB;
    }
    
}

public class ShapeFactory{
    public static myShape CreateShape(){
        Random random = new Random();
        int shapeType = random.Next(3); // 随机生成0、1或2

        switch (shapeType){
            case 0: // 创建长方形
                return new Rectangle(random.NextDouble() * 10, random.NextDouble() * 10);
            case 1: // 创建正方形
                return new Square(random.NextDouble() * 10);
            case 2: // 创建三角形
                // 随机生成合法的三角形边长
                double sideA = random.NextDouble() * 10;
                double sideB = random.NextDouble() * 10;
                double sideC = random.NextDouble() * 10;
                while (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA){
                    sideC = random.NextDouble() * 10;
                }
                return new Triangle(sideA, sideB, sideC);
            default:
                throw new InvalidOperationException("错误的形状！");
        }
    }
}

public class Program{
    public static void Main(){
        Random random = new Random();
        double totalArea = 0;

        for (int i = 0; i < 10; i++){
            myShape shape = ShapeFactory.CreateShape();
            double area = shape.CalculateArea();
            totalArea += area;

            Console.WriteLine($"第 {i + 1} 个图形: 面积 = {area:F2}");
        }

        Console.WriteLine($"总面积: {totalArea:F2}");
    }
}  
        
