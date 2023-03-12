using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ShapeClass
{
    //形状类
    public abstract class Shape
    {
        protected bool validity = false;
        protected double area = 0;

        public bool GetValidity() { return validity; }
        public double GetArea() { return area; }
        public abstract void Judge();
        public abstract void Calculate();

    }
    
    //三角形类
    public class Triangle : Shape
    {
        protected double a = 0;
        protected double b = 0;
        protected double c = 0;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void Judge()
        {
            if (a <= 0 || b <= 0 || c <= 0 || (a + b) <= c || (b + c) <= a || (c + a) <= b)
                return;
            validity = true;
        }
        public override void Calculate()
        {
            if (!validity)
                return;
            double p = (a + b + c) / 2;
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }

    //长方形类
    public class Rectangle : Shape
    {
        protected double width = 0;
        protected double length = 0;

        public Rectangle() { }
        public Rectangle(double w, double l)
        {
            width = w;
            length = l;
        }

        public override void Judge()
        {
            if (width <= 0 || length <= 0)
                return;
            validity = true;
        }
        public override void Calculate()
        {
            if (!validity)
                return;
            area = width * length;
        }


    }

    //正方形类
    public class Square : Rectangle
    {
        public Square() { }
        public Square(double edge)
        {
            width = edge;
            length = edge;
        }
        
        public override void Judge()
        {
            if (width <= 0 || length <= 0 || width != length)
                return;
            validity = true;
        }

    }

    //椭圆类
    public class Ellipse : Shape
    {
        protected double a = 0;
        protected double b = 0;

        public Ellipse() { }
        public Ellipse(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override void Judge()
        {
            if (a <= 0 || b <= 0)
                return;
            validity = true;
        }
        public override void Calculate()
        {
            if (!validity)
                return;
            area = 3.14 * a * b;
        }
    }

    //圆类
    public class Circle : Ellipse
    {
        public Circle() { }
        public Circle(double r)
        {
            a = r;
            b = r;
        }

        public override void Judge()
        {
            if (a <= 0 || b <= 0 || a != b)
                return;
            validity = true;
        }

    }

    //形状判断类
    public class ShapeJudegement
    {
        public ShapeJudegement() { }
        public bool JudgeShape(Shape shape)
        {
            shape.Judge();
            return shape.GetValidity();
        }
    }

    //形状面积计算类
    public class ShapeCalculation
    {
        public double CalculateShape(Shape shape)
        {
            shape.Judge();
            shape.Calculate();
            return shape.GetArea();
        }
    }
}