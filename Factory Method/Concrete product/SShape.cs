using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class SShape : Figure
    {
        public SShape()
        {
            FigureSize[0, 2] = 1;
            FigureSize[0, 1] = 1;
            FigureSize[1, 1] = 1;
            FigureSize[1, 0] = 1;
        }
    }
}
