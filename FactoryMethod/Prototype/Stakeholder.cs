

namespace Prototype
{
    internal class Stakeholder : Operaciones
    {
        public Stakeholder()
        {
            Name = "Lucas Perez";
            Phone = "6478961";
            Email = "correo@correo.com";
        }
        public override void Draw()
        {
            Console.WriteLine($"Datos del Cliente: \n  Nombre: {Name} , \n Telefono: {Phone}, \n Correo: {Email}.");
        }
    }
}