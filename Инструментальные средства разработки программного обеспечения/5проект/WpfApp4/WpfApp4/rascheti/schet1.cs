using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.rascheti
{
    class schet1
    {
        private double r { get; set; }
        private double h { get; set; }

        public schet1(double r, double h)
        {
            this.r = r;
            this.h = h;
        }

        public double val1()
        {
            return Math.Round(2 * Math.PI * r * h, 3);
        }

        public double znk1()
        {
            return Math.Round(2 * Math.PI + 2 * Math.PI * Math.Round(r, 2), 3);
        }

        public double wer()
        {
            return Math.Round(h * Math.PI * Math.Round(r, 2), 3);
        }
    }
}
