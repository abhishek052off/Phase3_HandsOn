using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeHandson
{
    public class ShapeMaker
    {
        public Circle circle { get; set; }

        public Rectangle rectangle { get; set; }

        public Square square { get; set; }

        public ShapeMaker()
        {

        }

        public void DrawCircle()
        {
            circle = new Circle();
            circle.Draw();
        }

        public void DrawRectangle()
        {
            rectangle = new Rectangle();
            rectangle.Draw();
        }

        public void DrawSquare()
        {
            square = new Square();
            square.Draw();
        }
    }
}
