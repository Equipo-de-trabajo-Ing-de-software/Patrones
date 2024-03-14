

namespace Prototype
{
    internal class Proveedor : Operaciones
    {
        public Proveedor()
        {
            Name = "Empresa SIGES";
            Phone = "554561";
            Email = "siges@correo.com";
        }
        public override void Draw()
        {
            Console.WriteLine($"Datos de la Empresa:  \n  Nombre: {Name} , \n Telefono: {Phone}, \n Correo: {Email}.");
        }
    }
}

