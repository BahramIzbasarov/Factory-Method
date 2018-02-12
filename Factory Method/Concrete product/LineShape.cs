using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class LineShape : Figure
    {
        public LineShape()
        {
            FigureSize[0, 1] = 1;
            FigureSize[1, 1] = 1;
            FigureSize[2, 1] = 1;
            FigureSize[3, 1] = 1;
        }
    }
}
