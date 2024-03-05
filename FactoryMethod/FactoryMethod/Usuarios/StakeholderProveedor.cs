namespace FactoryMethod.Usuarios
{
    public class StakeholderProveedor : IStakeholders
    {
        public string Name { get; set; }

        public string Type => "Proveedores";

        public void Contactar()
        {
            Console.WriteLine($"Contactando al Proveedor {Name}");
        }
    }
}