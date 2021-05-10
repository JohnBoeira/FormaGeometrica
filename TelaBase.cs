using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica
{
    public class TelaBase
    {
        ControleBase controleBase = new ControleBase();
        public void PedirLados()
        {
            Triangulo triangulo = new Triangulo();
            double x, y, z;
            Console.WriteLine("Digite 1º Lado:");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Digite 2º Lado:");
            double.TryParse(Console.ReadLine(), out y);
            Console.WriteLine("Digite 3º Lado:");
            double.TryParse(Console.ReadLine(), out z);

            triangulo.x = x;
            triangulo.y = y;
            triangulo.z = z;
            MostraResultado(triangulo);
        }

        public void MostraResultado( Triangulo triangulo)
        {
            if (triangulo.TrianguloValido())
            {
                Console.WriteLine(controleBase.VerificarTipo(triangulo));
            }
            else
            {
                Console.WriteLine("Triangulo Inválido");
                PedirLados();
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
