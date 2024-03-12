namespace FactoryMethod.Fabrica
{
    internal class RequisitoNoFuncional : IRequisito
    {
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CrearRequisito()
        {
            throw new NotImplementedException();
        }
    }
}