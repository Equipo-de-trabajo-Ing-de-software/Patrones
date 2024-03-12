using Factory.Requisitos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Fabrica
{
    internal class RequisitoNoFuncionalFactory : IRequisitoFactory
    {
        public IRequisito CrearRequisito()
        {
            return new RequisitoNoFuncional();
        }
    }
}
