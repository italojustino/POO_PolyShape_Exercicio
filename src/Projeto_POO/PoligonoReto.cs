using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class PoligonoReto {
        protected double _base;
        protected double _altura;
        public PoligonoReto(double basePoligono, double alturaPoligono)
        {
            _base = basePoligono;
            _altura = alturaPoligono;
        }
        protected double CalcularArea()
        {
            return _base * _altura;
        }
        protected double CalcularPerimetro()
        {
            return 2 * (_base + _altura);
        }
    }
}
