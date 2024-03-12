using FactoryMethod;
using FactoryMethod.Fabrica;

try
{
    IRequisito requisitoFuncional = RequisitoFactory.CrearRequisito("Funcional");
    IRequisito requisitoNoFuncional = RequisitoFactory.CrearRequisito("No Funcional");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
