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
        public IProveedor CreateIdProveedor()
        {
            return new Proveedor();
        }

        public IStakeholder CreateIdStakeholder()
        {
            return new Stakeholder();
        }
    }
}
