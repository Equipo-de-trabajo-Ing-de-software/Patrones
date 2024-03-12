using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Fabrica
{
    public interface IRequisitoFactory
    {
       IRequisito CrearRequisito(string type);


    }
}
