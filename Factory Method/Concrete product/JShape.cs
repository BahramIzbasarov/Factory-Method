using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class JShape : Figure
    {
        public JShape()
        {
            FigureSize[0, 1] = 1;
            FigureSize[1, 1] = 1;
            FigureSize[2, 1] = 1;
            FigureSize[2, 0] = 1;
        }
    }
}
