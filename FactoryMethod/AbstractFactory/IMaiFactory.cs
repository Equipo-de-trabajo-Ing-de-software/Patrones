
namespace PatronesCreacionale.AbstractFactory
{
    //Cada fabrica debe implementar esta interfaz 
    public interface IMaiFactory
    {
        IStakeholder CreateStakeholder();
        IProveedor CreateProveedor();


    }
}
