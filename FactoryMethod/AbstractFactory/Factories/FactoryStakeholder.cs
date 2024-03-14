
using PatronesCreacionale.AbstractFactory.ConcreteClasses;


namespace PatronesCreacionale.AbstractFactory.Factories
{
    public class FactoryStakeholder : IMaiFactory
    {
        public IProveedor CreateProveedor()
        {
            return new Proveedor();
        }

        public IStakeholder CreateStakeholder()
        {
            return new Stakeholder();
        }
    }
}
