using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Proveedor : Operaciones
    {
        public Proveedor()
        {
            Name = "Proveedor";
        }
        public override void Draw()
        {
            Console.WriteLine($"El Id del Proveedor es: {Id}.");
        }
    }
}

