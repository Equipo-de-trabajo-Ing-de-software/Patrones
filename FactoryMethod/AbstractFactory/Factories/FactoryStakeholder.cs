using AbstractFactory.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class FactoryStakeholder : IMaiFactory
    {
        public IProveedor CreateProveedor()
        {
            return new Proveedor();
        }

        public IStakeholder CreateStakeholder()
        {
            return new Stakeholder();
        }
    }
}
