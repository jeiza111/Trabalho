using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    class Ave: Animal
    {
        public void Migra()
        {
            Console.WriteLine("As aves migram quando acha necessario");
        }
        public override void Locomove()
        {
            base.Locomove();
            Console.WriteLine("As aves voam");
        }
        public override void comunica()
        {
            Console.WriteLine("As aves elas piam");
        }
    }
}
