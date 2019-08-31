using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class Program
    {
        static void Main()
        {
            Humano estudante = new Humano(13, "to com fome", 1, 50, "123456789");

            estudante.Amamenta();
            estudante.comunica();
            estudante.Cresce(4);
            estudante.Locomove();
            estudante.Nasce();
            estudante.reproduz();
            estudante.Sorri();
            
        }
               
    }
}
