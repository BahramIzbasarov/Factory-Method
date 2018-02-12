using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class TShapeCreator : FigureCreator
    {
        public override Figure NewFigure()
        {
            TShape shape = new TShape();
            return shape;
        }
    }
}
