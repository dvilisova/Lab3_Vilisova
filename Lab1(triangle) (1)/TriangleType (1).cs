using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using static Lab1_triangle_.AppDate;


public class TriangleType
{
    public (string, int[], string) Method(string st1, string st2, string st3)
    {

        int x1;
        int y1;
        int x2;
        int y2;
        int x3;
        int y3;


        string typeTriangle = "";
        string error_triangle = "";


        Log.Information($"Введены значения А {st1} В {st2} С {st3} ");
        Log.Information("Проверка значений на пустые строки.");
        Log.Information("Проверка значений на значение 0 в поле ввода.");


        if (string.IsNullOrEmpty(st1) || string.IsNullOrEmpty(st2) || string.IsNullOrEmpty(st3))
        {
            Log.Error("Не введены значения сторон");

            typeTriangle = "Не введены значения сторон";
            error_triangle = "Не введены значения сторон";
            x1 = x2 = x3 = y1 = y2 = y3 = -2;

        }
        else if (float.Parse(st1) <= 0 || float.Parse(st2) <= 0 || float.Parse(st3) <= 0)
        {
            Log.Error("Значение стороны равно 0");

            typeTriangle = "не треугольник";
            error_triangle = "не треугольник";
            x1 = x2 = x3 = y1 = y2 = y3 = -2;
        }
        else
        {

            Log.Information("Проверка на пустые строки пройдена");
            Log.Information("Проверка на значение 0 в поле ввода пройдена");
            Log.Information("Проверка на правильность треугольника");
            float side1 = float.Parse(st1);
            float side2 = float.Parse(st2);
            float side3 = float.Parse(st3);
            bool isTriangleExists = IsTriangleExists(side1, side2, side3);
            if (isTriangleExists == true)
            {
                Log.Information("Проверка на правильность треугольника пройдена");
                typeTriangle = TypeTriangle(side1, side2, side3);
                Triangle triangle = new Triangle(side1, side2, side3);
                triangle.ScaleCoordinates();
                //ВОЗВРАЩАЕТ!!!!!!!!!!!!!!!!!!!!!!
                x1 = (int)triangle.Vertex1.X;
                y1 = (int)triangle.Vertex1.Y;
                x2 = (int)triangle.Vertex2.X;
                y2 = (int)triangle.Vertex2.Y;
                x3 = (int)triangle.Vertex3.X;
                y3 = (int)triangle.Vertex3.Y;



                //DrawTriangle(side1, side2, side3);
                //VivodA.Text = "(X)" + Convert.ToString(triangle.Vertex1.X) + "  (Y)  " + Convert.ToInt32(triangle.Vertex1.Y);
                //VivodB.Text = "(X)" + Convert.ToString(triangle.Vertex2.X) + "  (Y)  " + Convert.ToInt32(triangle.Vertex2.Y);
                //VivodC.Text = "(X)" + Convert.ToString(triangle.Vertex3.X) + "  (Y)  " + Convert.ToInt32(triangle.Vertex3.Y);

            }
            else
            {
                Log.Error("Такого треугольника не существует, введены некорректные значения");

                typeTriangle = "не треугольник";
                error_triangle = "не треугольник";
                x1 = x2 = x3 = y1 = y2 = y3 = -1;
            }
        }
        //Log.CloseAndFlush();

        //AppDateTest(st1, st2, st3, typeTriangle, error_triangle);
        return (typeTriangle, new int[] { x1, y1, x2, y2, x3, y3,  }, error_triangle);
        
    }


    //метод, который проверяет на правильность треугольника
    public bool IsTriangleExists(double side1, double side2, double side3)
    {
        return side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2;
    }


    //метод, определяющий тип треугольника
    //
    public string TypeTriangle(double side1, double side2, double side3)
    {
        string typeTriangle = "";
        Log.Information("Определение типа треугольника");
        if (side1 == side2 && side1 == side3)
        {
            typeTriangle = "Равносторонний";
            Log.Information("Определение типа треугольника - равносторонний");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            typeTriangle = "Равнобедренный";
            Log.Information("Определение типа треугольника - равнобедренный");
        }
        else
        {
            typeTriangle = "Разносторонний";
            Log.Information("Определение типа треугольника - разносторонний");
        }
        return typeTriangle;

    }

    //метод, высчитывающий координаты
    public class Triangle
    {
        public Point Vertex1 { get; set; }
        public Point Vertex2 { get; set; }
        public Point Vertex3 { get; set; }

        public Triangle(double sideLength1, double sideLength2, double sideLength3)
        {
            // Расчет углов и координат треугольника
            double angleA = Math.Acos((sideLength2 * sideLength2 + sideLength3 * sideLength3 - sideLength1 * sideLength1) / (2 * sideLength2 * sideLength3));
            double angleB = Math.Acos((sideLength1 * sideLength1 + sideLength3 * sideLength3 - sideLength2 * sideLength2) / (2 * sideLength1 * sideLength3));

            Vertex1 = new Point(0, 0);
            Vertex2 = new Point(sideLength3, 0);
            Vertex3 = new Point(sideLength2 * Math.Cos(angleA), sideLength2 * Math.Sin(angleA));
        }

        public void ScaleCoordinates()
        {
            // Находим максимальное значение координаты по осям X и Y
            double maxX = Math.Max(Vertex1.X, Math.Max(Vertex2.X, Vertex3.X));
            double maxY = Math.Max(Vertex1.Y, Math.Max(Vertex2.Y, Vertex3.Y));

            // Если координаты превышают 100, масштабируем их
            if (maxX > 100 || maxY > 100)
            {
                double scaleFactor = Math.Min(100 / maxX, 100 / maxY);
                Vertex1.X *= scaleFactor;
                Vertex1.Y *= scaleFactor;
                Vertex2.X *= scaleFactor;
                Vertex2.Y *= scaleFactor;
                Vertex3.X *= scaleFactor;
                Vertex3.Y *= scaleFactor;
            }
        }
    }


    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    //        private void DrawTriangle(double side1, double side2, double side3)
    //        {
    //            Log.Information("Рисование треугольника");
    //            Canvas canvas = otrisovka;
    //            canvas.Width = 100;
    //            canvas.Height = 100;
    //            canvas.ClipToBounds = true;
    //            //Triangle triangle = new Triangle(side1, side2, side3);
    //           // Polygon triangl = new Polygon();
    //           // triangl.Points = new PointCollection() { new Point(triangle.Vertex1.X, triangle.Vertex1.Y), new Point(triangle.Vertex2.X, triangle.Vertex2.Y), new Point(triangle.Vertex3.X, triangle.Vertex3.Y) };
    //            Color newColor = Color.FromRgb(100, 130, 116);

    //            double desiredWidth = 80; // Желаемая ширина треугольника
    //            double desiredHeight = 60; // Желаемая высота треугольника
    //            //canvas.Children.Add(triangl);
    //            double scaleX = desiredWidth / Math.Max(side1, Math.Max(side2, side3));
    //            double scaleY = desiredHeight / Math.Max(side1, Math.Max(side2, side3));

    //            // Установка масштабирования
    //            ScaleTransform scaleTransform = new ScaleTransform(scaleX, scaleY);

    //            // Создание треугольника с пропорционально масштабированными сторонами
    //            Polygon triangle = new Polygon();
    //            triangle.Points = new PointCollection()
    //{
    //    new Point(0, 0),
    //    new Point(side1 * scaleX, 0),
    //    new Point((side3 * scaleX + ((side1 - side3) * scaleX) / 2), side2 * scaleY)
    //};

    //            triangle.Fill = Brushes.Red; // Задайте нужную заливку треугольника
    //            triangle.RenderTransform = scaleTransform; 
    //            triangle.Fill = new SolidColorBrush (newColor);
    //            triangle.Stretch = Stretch.Uniform;

    //            // Добавление треугольника на Canvas
    //            canvas.Children.Add(triangle);

    //        }
}
