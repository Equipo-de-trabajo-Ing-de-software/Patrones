using FactoryMethod.Fabrica;
using FactoryMethod;

StakeholderFactory clienteFactory = new StakeholderClienteFactory();
StakeholderFactory proveedorFactory = new StakeholderProveedorFactory();
// StakeholderFactory gobiernoFactory = new StakeholderGobiernoFactory();


IStakeholders cliente = clienteFactory.CrearStakeholders();
cliente.Name = "Juan Pérez";
cliente.Contactar();

IStakeholders proveedor = proveedorFactory.CrearStakeholders();
proveedor.Name = "Empresa Z";
proveedor.Contactar();

//IStakeholder gobierno = gobiernoFactory.CreateStakeholder();
//gobierno.Nombre = "Ministerio de Industria";
//gobierno.Contactar();