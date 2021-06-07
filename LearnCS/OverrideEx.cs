using System;
namespace LearnCS
{
    public abstract class Shape { // Base class

        int a = 10;

        public void print()
        {
            Console.WriteLine("print");
        }

        public abstract void draw(); // abstract
    }
    public sealed class Rectangle : Shape { // derived class
        public override void draw() {
            Console.WriteLine("drawing rectangle...");
        } }

    //public class Square: Rectangle
    //{

    //}

    public class Circles : Shape{ // derived class
        public override void draw(){
            Console.WriteLine("drawing circle...");
    }}
    class OverrideEx{
          void Main(){
            Shape s;
            s = new Rectangle();
            s.draw();
            s = new Circles();
            s.draw();
            Console.Read();
        }
    }
}
