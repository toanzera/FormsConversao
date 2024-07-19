using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TauanMaciel
{
    public class Model
    {

        public double Polegada(double x)
        {
            return x*2.54;
        }
        public double Pe(double x)
        {
            return x * 0.3048;
        }
        public double Milha(double x)
        {
            return x * 1.6093;
        }
        public double Galao(double x)
        {
            return x * 3.7854;
        }
        public double Libra(double x)
        {
            return x * 0.4536;
        }
        public double Cm(double x)
        {
            return x * 0.3937;
        }
        public double Metro(double x)
        {
            return x * 3.2808;
        }
        public double Quilometro(double x)
        {
            return x * 0.6214;
        }
        public double Litro(double x)
        {
            return x * 0.2642;
        }
        public double Kg(double x)
        {
            return x * 2.2046;
        }
    }
}   
