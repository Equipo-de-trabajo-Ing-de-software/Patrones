using FactoryMethod.Usuarios;

namespace FactoryMethod.Fabrica
{
    public class StakeholderProveedorFactory : StakeholderFactory
    {
        public override IStakeholders CrearStakeholders()
        {
            return new StakeholderProveedor();
        }
    }
}
