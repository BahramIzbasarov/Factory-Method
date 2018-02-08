using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public abstract class Figure
    {
        private int[,] figureSize = new int[4, 4];
        private string name;
        private RGB rgb;
        
        public string Name
        {
            get => name;
            set => name = value;
        }

        public int[,] FigureSize
        {
            get => figureSize;
            set => figureSize = value;
        }

        public RGB RGB
        {
            get => rgb;
            set => rgb = value;
        }
    }
}
