using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class LShapeCreator : FigureCreator
    {
        public override Figure NewFigure()
        {
            LShape shape = new LShape();
            return shape;
        }
    }
}
