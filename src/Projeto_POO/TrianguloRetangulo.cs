using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyShape
{
    internal class TrianguloRetangulo : PoligonoReto
    {
        private double _hipotenusa;
        public TrianguloRetangulo(double baseTriangulo, double alturaTriangulo, double hipotenusa) : base(baseTriangulo, alturaTriangulo)
        {
            _hipotenusa = hipotenusa;
        }
        public override double CalcularArea()
        {
            return (_base * _altura) / 2;
        }
        public override double CalcularPerimetro()
        {
            return _base + _altura + _hipotenusa;
        }
    }
}
