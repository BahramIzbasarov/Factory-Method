using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class OShapeCreator : FigureCreator
    {
        public override Figure NewFigure()
        {
            OShape shape = new OShape();
            return shape;
        }
    }
}
