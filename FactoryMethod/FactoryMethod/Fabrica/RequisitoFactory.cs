using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Fabrica
{
    internal class RequisitoFactory : IRequisitoFactory
    {
        public IRequisito CrearRequisito(string type)
        {
            throw new NotImplementedException();
        }
    }
}
