namespace FactoryMethod.Usuarios
{
    internal class RequisitoFuncional : IRequisito
    {
        public string Id { get; set; }
        public string Name { get ; set; }
        public string Type => "Requisitos Funcionales";

        public void CrearRequisito()
        {
            Console.WriteLine($"{Type}");
        }
    }
}