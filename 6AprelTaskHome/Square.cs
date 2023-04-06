using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6AprelTaskHome
{
    internal class Square : Figure
    {
        private int _side;
        public int Side
        {
            get
            {
                return _side;
            }

            set
            {
                if (value > 0)
                {
                    _side = value;
                }
            }
        }
            
            public Square(int side)
        {
            Side = side;
        }

    
        public override double CalcArea()
        {
            return Side * Side;
        }
        public override double CalcPerimeter()
        {
            return 4 * Side;
        }
    }
}
