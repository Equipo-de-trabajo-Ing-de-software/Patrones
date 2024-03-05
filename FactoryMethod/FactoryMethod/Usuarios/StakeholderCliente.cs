namespace FactoryMethod.Usuarios
{
    public class StakeholderCliente : IStakeholders
    {
        public string Name { get; set; }

        public string Type => "Cliente";

        public void Contactar()
        {
            Console.WriteLine($"Contactando al Cliente {Name}");
        }
    }
}