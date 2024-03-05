using FactoryMethod.Usuarios;


namespace FactoryMethod.Fabrica
{
    public class StakeholderClienteFactory : StakeholderFactory
    {
        public override IStakeholders CrearStakeholders()
        {
            return new StakeholderCliente();
        }
    }
}
