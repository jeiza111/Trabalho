using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class Mamifero: Animal 
    {
        public void Amamenta()
        {

        }
        public override void Locomove()
        {
            Console.WriteLine("Os mamiferos se locomovem");
        }
        public override void comunica()
        {
            Console.WriteLine("Os mamiferos se comunicam");
        }
    }
}
