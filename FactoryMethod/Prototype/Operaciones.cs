
namespace Prototype
{
    public abstract class Operaciones : ICloneable
    {
    
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public abstract void Draw();

        //Metodo devuelve la copia del objeto
        public object Clone()
        {
            return MemberwiseClone();
        }
    }

}