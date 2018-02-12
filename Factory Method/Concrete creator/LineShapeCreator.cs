using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class LineShapeCreator : FigureCreator
    {
        public override Figure NewFigure()
        {
            LineShape shape = new LineShape();
            return shape;
        }
    }
}
