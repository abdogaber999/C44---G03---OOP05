using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session05_Solution.Shapes
{
    internal class Rectangle : IRectangle
    {
        #region Properties
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area { get; set; }
        #endregion

        #region Constructors
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
            Area = width * height;
        }
        #endregion

        #region Methods
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle -> Width: {Width}, Height: {Height}, Area: {Area}");
        }
        #endregion
    }
}
