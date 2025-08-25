using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session05_Solution.Shapes
{
    internal interface ICircle: IShape
    {
        double Radius { get; set; }
    }
}
