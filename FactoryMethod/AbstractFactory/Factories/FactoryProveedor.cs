using AbstractFactory.ConcreteClasses;


namespace AbstractFactory.Factories
{
    public class FactoryProveedor : IMaiFactory
    {
        public IProveedor CreateIdProveedor()
        {
            return new Proveedor();
        }

        public IStakeholder CreateIdStakeholder()
        {
            return new Stakeholder();
        }
    }
}
