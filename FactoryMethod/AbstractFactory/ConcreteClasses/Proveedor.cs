using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteClasses
{
    public class Proveedor : IProveedor
    {
        public void Render()
        {
            Console.WriteLine("Proveedor creado Correctamente");
        }
    }
}
