
using AbstractFactory;
using AbstractFactory.Factories;

IMaiFactory fabricaPrincipal = new FactoryStakeholder();
IStakeholder stakeholder = fabricaPrincipal.CreateStakeholder();
stakeholder.Render();

Console.WriteLine();

IProveedor proveedor = fabricaPrincipal.CreateProveedor();
proveedor.Render();
