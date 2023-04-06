using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6AprelTaskHome
{
    internal class Circle:Figure
    {
        private int _sideR;
        public int SideR
        {
            get
            {
                return _sideR;
            }
            set
            {
                if (value > 0)
                {
                    _sideR = value;
                }
            }
        }

            public Circle(int sider)
        {
             SideR = sider;   
        }
       public double a = 3.14;
      
        public override double CalcArea()
        {
            return SideR * SideR * a;
        }
        public override double CalcPerimeter()
        {
            return 2* SideR * a;
        }
        
    }
}
