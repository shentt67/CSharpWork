using System;

namespace b4
{
    public interface method
    {
        void Info();       
        bool judge();
    }

    abstract class TwoDshape
    {
        double Width, Height;
        string Name;
        public abstract double area();

        public double width
        {
            get { return Width; }
            set { Width = value; }
        }
        public double height
        {
            get { return Height; }
            set { Height = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
    }

    class Rectangle : TwoDshape, method
    {
        public Rectangle(string n,double a,double b)
        {
            this.name = n;
            this.width = a;
            this.height = b;
        }
        public override double area()
        {
            return width * height;
        }

        public void Info()
        {
            Console.WriteLine("The width and height of Rectangle:" + width + " " + height);
        }

        public bool judge()
        {
            if (this.name == "Rectangle")
            {
                Console.WriteLine("It is a Rectangle");
                return true;
            }
            else
            {
                Console.WriteLine("Illegal");
                return false;
            }
        }
    }

    class Square : TwoDshape, method
    {
        public Square(string n, double a, double b)
        {
            this.name = n;
            this.width = a;
            this.height = b;
        }
        public override double area()
        {
            return width * height;
        }

        public void Info()
        {
            Console.WriteLine("The width and height of Square:" + width + " " + height);
        }

        public bool judge()
        {
            if (this.name == "Square"&&width==height)
            {
                Console.WriteLine("It is a Square");
                return true;
            }
            else
            {
                Console.WriteLine("Illegal");
                return false;
            }
        }
    }

    class Triangle : TwoDshape, method
    {
        public Triangle(string n, double a, double b)
        {
            this.name = n;
            this.width = a;
            this.height = b;
        }
        public override double area()
        {
            return width * height/2;
        }

        public void Info()
        {
            Console.WriteLine("The width and height of Triangle:" + width + " " + height);
        }

        public bool judge()
        {
            if (this.name == "Triangle")
            {
                Console.WriteLine("It is a Triangle");
                return true;
            }
            else
            {
                Console.WriteLine("Illegal");
                return false;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle("Rectangle", 2.3, 6.2);
            Console.WriteLine("The area:" + r.area());
            r.judge();

            Square s = new Square("Square", 5, 5);
            Console.WriteLine("The area:" + s.area());
            s.judge();

            Triangle t = new Triangle("Square", 5, 5);
            Console.WriteLine("The area:" + t.area());
            t.judge();
        }
    }
}
