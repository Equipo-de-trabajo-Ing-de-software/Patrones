namespace FactoryMethod.Fabrica
{
    internal class RequisitoNoFuncional : IRequisito
    {
        public string Id { get ; set ; }
        public string Name { get ; set ; }
        public string Type { get ; set ; }

        public void CrearRequisito()
        {
            throw new NotImplementedException();
        }
    }
}