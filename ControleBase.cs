using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica
{
    class ControleBase
    {
        
        public string VerificarTipo(Triangulo triangulo)
        {
            if (triangulo.x == triangulo.z && triangulo.z == triangulo.y)
            {
                return "Triangulo equilátero!";
            }
            else if (triangulo.x != triangulo.z && triangulo.z != triangulo.y && triangulo.x != triangulo.y)
            {
                return "Triangulo Escaleno!";
            }
            else
            {
                return "Triangulo Isósceles!";
            }
        }
    }
}
