using FactoryMethod.Usuarios;

namespace FactoryMethod.Fabrica
{
    public class RequisitoFuncionalFactory : IRequisitoFactory
    {
        public IRequisito CrearRequisito(string type)
        {
          if(type == "Funcional")
            {
                return new RequisitoFuncional();
            }
            else
            {
                throw new ArgumentNullException("Tipo de requisito no valido");
            }
               
        }
    }
}