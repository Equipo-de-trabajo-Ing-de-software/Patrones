using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Operaciones : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void Draw();

        //Metodo devuelve la copia del objeto
        public object Clone()
        {
            return MemberwiseClone();
        }
    }

}