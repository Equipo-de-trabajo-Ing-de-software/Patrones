using AbstractFactory.ConcreteClasses;


namespace AbstractFactory.Factories
{
    public class FactoryProveedor : IMaiFactory
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
