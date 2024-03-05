using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public interface ICloneable
    {
        //Object es la clase base de todos los clases, aqui se devuelve un tipo de datos. 
        object Clone();
    }
}