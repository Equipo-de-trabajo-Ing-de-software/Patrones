
using FactoryMethod.Fabrica;
Console.WriteLine(" Uso del patrón Método de Fábrica");// Uso del patrón Factory Method

var functionalRequirementHandler = new FunctionalRequirementHandler();

// Crear un requisito funcional
var functionalRequirement = functionalRequirementHandler.CreateRequirement();
functionalRequirement.Title = "El sistema debe permitir la creación de usuarios";
functionalRequirement.Description = "Los usuarios deben poder registrarse e iniciar sesión en el sistema";
functionalRequirement.Priority = 1;
//functionalRequirement.Type = "Requisito Funcional";

Console.WriteLine("Título del Requisito: " + functionalRequirement.Title);
Console.WriteLine("Descripción del Requisito: " + functionalRequirement.Description);
Console.WriteLine("Prioridad del Requisito: " + functionalRequirement.Priority);

// Eliminar el requisito funcional
//functionalRequirement.Delete();

Console.WriteLine();
var nonFunctionalRequirementHandler = new NonFunctionalRequirementHandler();
var nonFunctionalRequirement = nonFunctionalRequirementHandler.CreateRequirement();
nonFunctionalRequirement.Title = "Rendimiento";
nonFunctionalRequirement.Description = "Tiempo de respuesta menor a 2 segundos";
nonFunctionalRequirement.Priority = 2;

Console.WriteLine("Título del Requisito: " + nonFunctionalRequirement.Title);
Console.WriteLine("Descripción del Requisito: " + nonFunctionalRequirement.Description);
Console.WriteLine("Prioridad del Requisito: " + nonFunctionalRequirement.Priority);