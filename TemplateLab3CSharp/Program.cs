using System;


namespace Lab3
{
    
    //1.1. Задано масив точок. Вивести в консоль інформацію про точку та
    //відстань до центра координат. Точки які знаходяться більше
    //середньої відстані, перемістити на заданий вектор. Створити клас
    //Point
    class Point
    {
        private int x, y;
        private readonly int c;

        public Point()
        {
            x = 0;
            y = 0;
            c = 0;
        }

        public Point(int x_, int y_, int c_)
        {
            x = x_;
            y = y_;
            c = c_;
        }

        public void Print()
        {
            Console.WriteLine($"x: {x}, y: {y}, color: {c}");
        }

        public double Distance()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public void Move(int x1, int y1)
        {
            x = x + x1;
            y = y + y1;
        }

        public void setX(int newX)
        {
            x = newX;
        }

        public int getX()
        {
            return x;
        }

        public void setY(int newY)
        {
            y = newY;
        }

        public int getY()
        {
            return y;
        }

        public int getColor()
        {
            return c;
        }

    }
    
    //2.11. Автомобіль, поїзд, транспортний засіб, експрес
    class TransZasib
    {
        protected double maxSpeed;

        public TransZasib()
        {
            maxSpeed = 0;
        }

        public TransZasib(double speed)
        {
            maxSpeed = speed;
        }

        public void Show()
        {
            Console.WriteLine($"Max Speed: {maxSpeed}");
        }
    }

    class Auto : TransZasib
    {
        
        public Auto()
        {
            maxSpeed = 250;
        }

        public Auto(double maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }
        
    }
    
    class Train : TransZasib
    {
        
        public Train()
        {
            maxSpeed = 150;
        }

        public Train(double maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }
        
    }
    
    class Express : TransZasib
    {
        
        public Express()
        {
            maxSpeed = 300;
        }

        public Express(double maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }
        
    }
    
    
    static class Program
    {
        static void Main()
        {
            Point a = new Point();
            Point b = new Point(2, 3, 4);
            Console.Write("A: ");
            a.Print();
            Console.Write("B: ");
            b.Print();
            Console.WriteLine($"B-0: {b.Distance()}");
            a.Move(3,5);
            Console.Write("A moved to 3,5: ");
            a.Print();
            a.setX(10);
            Console.Write("A x set to 10: ");
            a.Print();
            //-----------------
            TransZasib transZasib = new TransZasib();
            transZasib.Show();
            Auto auto = new Auto(120);
            auto.Show();
            Train train = new Train();
            train.Show();
            Express express = new Express(400);
            express.Show();
        }
    }
    
}