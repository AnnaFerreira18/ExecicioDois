using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecicioDois
{
    internal class Circulo
    {
        double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }
        public double area()
        {
            return 3.14 * Math.Pow(raio, 2);
        }
        public double perimetro()
        {
            return 2 * 3.14 * raio;
        }
    }
}
