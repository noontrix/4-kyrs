using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.rascheti
{
    class schet2
    {
        private double r { get; set; }
        private double h { get; set; }
        private double l { get; set; }

        public schet2(double r, double h, double l)
        {
            this.r = r;
            this.h = h;
            this.l = l;
        }

        public double val2()
        {
            return Math.Round(Math.PI * r * r, 3);
        }

        public double znk2()
        {
            return Math.Round(Math.Round(h * 1.0 / 3.0 * Math.PI * Math.Pow(r, 2), 3)); //double
        }

        public double wef()
        {
            return Math.Round(Math.PI * r * l, 3);
        }

        public double rgr()
        {
            return Math.Round(Math.PI * r * (r + l), 3);
        }
    }
}
