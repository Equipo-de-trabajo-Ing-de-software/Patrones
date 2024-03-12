
namespace FactoryMethod
{
    public interface IRequisito
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get;   }
      

        void CrearRequisito();
    }
}
