using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    
    class Circle
    {
        // member variable
        public static float PI; // 32
        public int radius; //32

        static Circle()
        {
            // get it from server or from file, configuration files
            PI = 3.14f;
            Console.WriteLine("Class constructorc called");
        }

        public Circle(int radius)
        {
            Console.WriteLine("Object constructorc called");
            this.radius = radius;
        }

        // member methods

        public static void print()
        {
            Console.WriteLine("hello");
        }

        public void Area()
        {
            Console.WriteLine("Area of the circle"+ Circle.PI * this.radius * this.radius);
        }

        public static bool Compare(Circle a, Circle b) // reference type
        {
            if (a.radius == b.radius)
                return true;
            return false;
        }
    }

    class StaticEx
    {
        public  void Main()
        {
            //Circle c = new Circle(5); // 32
            //Circle c1 = new Circle(6); // 32
            //Circle c2 = new Circle(7); // 32
            //Circle.print();
            //Circle.Compare(c, c1);
            //c.Area();

            //float x = Circle.PI;

            Circle c = new Circle(4);
                c.Area();

            Console.Read();
        }
    }
}
