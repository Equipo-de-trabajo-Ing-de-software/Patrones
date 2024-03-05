using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prototype
{
    internal class Stakeholder : Operaciones
    {
        public Stakeholder()
        {
            Name = "Stakeholder";
        }
        public override void Draw()
        {
            Console.WriteLine($"El Id del Stakeholde es: {Id}.");
        }
    }
}