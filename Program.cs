using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaGeometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            TelaBase tela = new TelaBase();
            while (true)
            {
                tela.PedirLados();
            }          
        }
    }
}
