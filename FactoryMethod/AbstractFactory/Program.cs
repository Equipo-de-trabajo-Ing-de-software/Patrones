
using AbstractFactory;
using AbstractFactory.Factories;

IMaiFactory fabricaPrincipal = new FactoryStakeholder();
IStakeholder stakeholder = fabricaPrincipal.CreateIdStakeholder();
stakeholder.Render();

Console.WriteLine();

IProveedor proveedor = fabricaPrincipal.CreateIdProveedor();
proveedor.Render();
