using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.rascheti
{
    class schet
    {
        private double r { get; set; }

        public schet(double r)
        {
            this.r = r;
        }

        public double val()
        {
            return Math.Round(4 / 3 * Math.PI * Math.Pow(r, 3), 3);
        }

        public double znk()
        {
            return Math.Round(4 * Math.PI * r * r, 3);
        }
    }
}
