using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeClass;

namespace ShapeObject
{
    class ShapeObject
    {
        static double SumOfShapes(Shape[] shapes)
        {
            double sumOfShapes = 0;
            ShapeCalculation C = new ShapeCalculation();
            for(int i = 0; i < shapes.Length; i++)
            {
                sumOfShapes += C.CalculateShape(shapes[i]);
            }
            return sumOfShapes;
        }
        
        
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[10];
            Random R = new Random();
            double sumOfShapes = 0;
            for(int i = 0; i < 10; i++)
            {
                int type = R.Next(0, 5);
                ShapeJudegement J = new ShapeJudegement();
                switch (type)
                {
                   case 0:
                        {
                            double a;
                            double b;
                            double c;
                            do
                            {
                                a = R.Next(25) + R.NextDouble();
                                b = R.Next(25) + R.NextDouble();
                                c = R.Next(25) + R.NextDouble();
                                shapes[i] = new Triangle(a, b, c);
                            } while (!J.JudgeShape(shapes[i]));
                            Console.WriteLine($"第{i + 1}个形状为三角形，边长分别为：{a}，{b}，{c}");
                            break;
                        }  
                    case 1:
                        {
                            double w;
                            double l;

                            do {
                                w = R.Next(25) + R.NextDouble();
                                l = R.Next(25) + R.NextDouble();
                                shapes[i] = new Rectangle(w, l);
                            } while (!J.JudgeShape(shapes[i]));
                            Console.WriteLine($"第{i + 1}个形状为长方形，宽为：{w}，长为{l}");
                            break;
                        }
                    case 2:
                        {
                            double e;
                            do {
                                e = R.Next(25) + R.NextDouble();
                                shapes[i] = new Square(e);
                            } while (!J.JudgeShape(shapes[i]));
                            Console.WriteLine($"第{i + 1}个形状为正方形，边长为：{e}");
                            break;
                        }
                    case 3:
                        {
                            double a;
                            double b;
                            do {
                                a = R.Next(25) + R.NextDouble();
                                b = R.Next(25) + R.NextDouble();
                                shapes[i] = new Ellipse(a, b);
                            } while (!J.JudgeShape(shapes[i]));
                            Console.WriteLine($"第{i + 1}个形状为椭圆形，半长轴为：{a}，半短轴为{b}");
                            break;
                        }
                    case 4:
                        {
                            double r;
                            do {
                                r = R.Next(25) + R.NextDouble();
                                shapes[i] = new Circle(r);
                            } while (!J.JudgeShape(shapes[i]));
                            Console.WriteLine($"第{i + 1}个形状为圆形，半径为：{r}");
                            break;
                        }
                    defualt: break;

                }
            }
            sumOfShapes = SumOfShapes(shapes);
            Console.WriteLine($"10个形状对象的面积之和：{sumOfShapes}");


        }
    }
}

