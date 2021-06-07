using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{

    public interface IShapes
    {
        void draw();
    }
    public interface IColors
    {
        void paint(string color);
    }

    class MicrosoftRectangles : IShapes, IColors
    {
        public void draw()
        {
            Console.WriteLine("Rectangle");
        }

        public void paint(string color)
        {
            Console.WriteLine("Painting color {0}", color);
        }
    }


    class InterfaceEx
    {
         void Main()
        {
            IShapes s = new MicrosoftRectangles();
            s.draw();
            IColors s1 = new MicrosoftRectangles();
            s1.paint("red");
        }
    }
}
