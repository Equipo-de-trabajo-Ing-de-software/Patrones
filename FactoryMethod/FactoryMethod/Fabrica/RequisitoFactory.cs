
namespace FactoryMethod.Fabrica
{
    internal class RequisitoFactory
    {
        private static readonly Dictionary<string, IRequisitoFactory> factory = new Dictionary<string, IRequisitoFactory>();

        static RequisitoFactory()
        {
            factory.Add("Funcional", new RequisitoFuncionalFactory());
            factory.Add("No Funcional", new RequisitoNoFuncionalFactory());
        }

        public static IRequisito CrearRequisito(string type)
        {
            if (factory.ContainsKey(type))
            {
                return factory[type].CrearRequisito(type);
            }
            else
            {
                throw new ArgumentException("Requerimiento Invalido");
            }
        }
    }
}