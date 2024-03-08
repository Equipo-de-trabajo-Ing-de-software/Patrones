

namespace AbstractFactory
{
    //Cada fabrica debe implementar esta interfaz 
    internal interface IMaiFactory
    {
        IStakeholder CreateIdStakeholder();
        IProveedor CreateIdProveedor();
    }
}
