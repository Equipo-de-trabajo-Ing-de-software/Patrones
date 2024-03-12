namespace FactoryMethod.Fabrica
{
    public class RequisitoNoFuncional : IRequisito
    {
        public string Id { get ; set ; }
        public string Name { get ; set ; }
        public string Type => "Requisitos No Funcionales";

        public void CrearRequisito()
        {
            Console.WriteLine($"{Type}");
        }
    }
}