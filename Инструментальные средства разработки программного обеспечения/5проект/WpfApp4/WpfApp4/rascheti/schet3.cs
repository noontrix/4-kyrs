using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.rascheti
{
    class schet3
    {
        private double r { get; set; }
        private double h { get; set; }
        private double l { get; set; }
        private double R { get; set; }

        public schet3(double r, double h, double l, double R)
        {
            this.r = r;
            this.h = h;
            this.l = l;
            this.R = R;

        }

        public double val3()
        {
            return Math.Round(Math.Round(Math.PI * R * R, 3));
        }

        public double znk3()
        {
            return Math.Round(Math.Round(Math.PI * r * r, 3));
        }

        public double wef3()
        {
            return Math.Round(Math.Round(h * 1 / 3 * Math.PI * (Math.Pow(r, 2) + Math.Pow(R, 2) + r * R), 3));
        }

        public double rgr3()
        {
            return Math.Round(Math.Round(Math.PI * l * (r + R) + Math.PI * Math.Pow(R, 2) + Math.PI * Math.Pow(r, 2), 3));
        }

        public double egr3()
        {
            return Math.Round(Math.PI * l * (r + R), 3);
        }
    }
}
