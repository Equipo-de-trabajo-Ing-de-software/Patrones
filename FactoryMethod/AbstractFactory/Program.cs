using PatronesCreacionale.AbstractFactory;
using PatronesCreacionale.AbstractFactory.Factories;


IMaiFactory fabricaPrincipal = new FactoryStakeholder();
IStakeholder stakeholder = fabricaPrincipal.CreateStakeholder();
stakeholder.Render();

Console.WriteLine();

IProveedor proveedor = fabricaPrincipal.CreateProveedor();
proveedor.Render();
