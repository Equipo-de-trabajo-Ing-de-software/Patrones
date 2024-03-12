
namespace FactoryMethod.Fabrica
{
    public class RequisitoNoFuncionalFactory : IRequisitoFactory
    {
        public IRequisito CrearRequisito(string type)
        {
            if (type == "No Funcional")
            {
                return new RequisitoNoFuncional();
            }
            else
            {
                throw new ArgumentNullException("Tipo de requisito no valido");
            }

        }
    }
}
