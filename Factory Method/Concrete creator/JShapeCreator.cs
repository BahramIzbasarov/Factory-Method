using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class JShapeCreator : FigureCreator
    {
        public override Figure NewFigure()
        {
            JShape shape = new JShape();
            return shape;
        }
    }
}
