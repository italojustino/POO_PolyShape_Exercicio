using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class PoligonoReto : Forma {
        protected double _base;
        protected double _altura;
        public PoligonoReto(double basePoligono, double alturaPoligono) : base("Polígono reto")
        {
            _base = basePoligono;
            _altura = alturaPoligono;
        }
        public virtual double CalcularArea()
        {
            return _base * _altura;
        }
        public virtual double CalcularPerimetro()
        {
            return 2 * (_base + _altura);
        }
    }
}
