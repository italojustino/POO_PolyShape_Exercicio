using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape {
    internal class TrianguloRetangulo : PoligonoReto {
        public TrianguloRetangulo(double baseTriangulo, double alturaTriangulo) : base(baseTriangulo, alturaTriangulo) {
        }
        public double CalcularPerimetro()
        {
            double hipotenusa = Math.Sqrt(_base * _base + _altura * _altura);
            return _base + _altura + hipotenusa;
        }
    }
}
