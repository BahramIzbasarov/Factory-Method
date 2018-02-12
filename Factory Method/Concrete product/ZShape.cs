using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class ZShape : Figure
    {
        public ZShape()
        {
            FigureSize[0, 0] = 1;
            FigureSize[0, 1] = 1;
            FigureSize[1, 1] = 1;
            FigureSize[1, 2] = 1;
        }

    }
}
