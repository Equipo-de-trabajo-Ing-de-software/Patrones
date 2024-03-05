using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Fabrica
{
    public abstract class StakeholderFactory
    {
        public abstract IStakeholders CrearStakeholders();

    }
}
