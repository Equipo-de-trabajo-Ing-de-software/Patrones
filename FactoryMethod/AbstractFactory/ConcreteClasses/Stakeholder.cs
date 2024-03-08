using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteClasses
{
    public class Stakeholder : IStakeholder
    {
        public void Render()
        {
            Console.WriteLine("Se Creo el Stakeholder");
        }
    }
}
