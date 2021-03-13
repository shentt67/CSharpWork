using System;

namespace b5
{
    abstract class shape
    {
        protected double width,height;
        public abstract double area();
    }

    class rectangle:shape
    {
        public rectangle()
        {
            Random r = new Random();
            width = 1 + 5 * r.NextDouble();
            height = 1 + 5 * r.NextDouble();
            Console.WriteLine("create a rectangle's area: "+this.area());
        }
        public override double area() 
        {
            return width * height;
        }
    }

    class square : shape
    {
        public square()
        {
            Random r = new Random();
            width = 1 + 5 * r.NextDouble();
            height = 1 + 5 * r.NextDouble();
            Console.WriteLine("create a square's area: " + this.area());
        }
        public override double area()
        {
            return width * height;
        }
    }

    class triangle : shape
    {
        public triangle()
        {
            Random r = new Random();
            width = 1 + 5 * r.NextDouble();
            height = 1 + 5 * r.NextDouble();
            Console.WriteLine("create a triangle's area: " + this.area());
        }
        public override double area()
        {
            return width * height/2;
        }
    }

    class producer
    {
        public static shape produce(string s)
        {
            switch (s)
            {
                case "rectangle":
                    return new rectangle();
                case "square":
                    return new square();
                case "triangle":
                    return new triangle();
                default:
                    return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double sum=0;
            Random r1 = new Random();
            string[] s1 = { "rectangle", "square", "triangle" };

            for (int i = 0; i < 10; i++)
            {
                shape ss=producer.produce(s1[r1.Next(3)]);
                sum += ss.area();
            }
            Console.WriteLine("Total: " + sum);     

        }
    }
}
