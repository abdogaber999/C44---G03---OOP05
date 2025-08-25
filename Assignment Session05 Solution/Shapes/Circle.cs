using System;

namespace Assignment_Session05_Solution.Shapes
{
    internal class Circle : ICircle
    {
        #region Properties
        public double Radius { get; set; }
        public double Area { get; set; }
        #endregion

        #region Constructors
        public Circle(double radius)
        {
            Radius = radius;
            Area = Math.PI * radius * radius;
        }
        #endregion

        #region Methods
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle -> Radius: {Radius}, Area: {Area:F2}");
        }
        #endregion
    }
}
