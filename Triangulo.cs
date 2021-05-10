using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica
{
    public class Triangulo
    {
        public double x, y, z;

        public bool TrianguloValido()
        {
            if (z > y + x || y > x + z || x > y + z)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }
}

