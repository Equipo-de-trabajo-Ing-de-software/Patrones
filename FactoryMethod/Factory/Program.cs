using Factory;
using Factory.Fabrica;

IRequisitoFactory funcionalFactory = new RequisitoFuncionalFactory();
IRequisito funcionalRequisito = funcionalFactory.CrearRequisito();
funcionalRequisito.TipoRequisito();

IRequisitoFactory nonFunctionalFactory = new RequisitoNoFuncionalFactory();
IRequisito nonFunctionalRequirement = nonFunctionalFactory.CrearRequisito();
nonFunctionalRequirement.TipoRequisito();