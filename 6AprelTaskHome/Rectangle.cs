using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6AprelTaskHome
{
    internal class Rectangle : Figure
    {
        private int _sideEn;
        public int SideEn 
        {
            get
            {
                return _sideEn;
            }

            set
            {
                if (value > 0)
                {
                    _sideEn = value;
                }
            } 
        }
        private int _sideUzunluq;
        public int SideUzunluq
        {
            get
            {
                return _sideUzunluq;
            }
            set
            {
                if (value > 0)
                {
                    _sideUzunluq = value;
                }
            }
        }
            public Rectangle(int sideEN,int sideUzunluq)
            {
            SideEn=sideEN;
            SideUzunluq=sideUzunluq;
            }
        public override double CalcArea()
        {
            return SideEn * SideUzunluq;
        }
        public override double CalcPerimeter()
        {
            return (SideEn + SideUzunluq) * 2;
        }
    }
}
