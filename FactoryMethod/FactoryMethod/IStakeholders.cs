
namespace FactoryMethod
{
    public interface IStakeholders
    {
        public string Name { get; set; }
        public string Type { get; }

        void Contactar();
    }
}
