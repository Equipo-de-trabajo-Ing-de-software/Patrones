
using Prototype;
using System.Xml.Linq;

Console.WriteLine("Valores Iniciales del Stakeholder y Proveedor");
Stakeholder stakeholder = new Stakeholder { Id = 1 };

Proveedor proveedor = new Proveedor { Id = 2 };


//Draw original Shapes
stakeholder.Draw();
proveedor.Draw();

Console.WriteLine();
//hacer los clones
Console.WriteLine("Clonar Stakeholder y Proveedor, con sus nuevos valores en el Id:");
Stakeholder clonedStakeholder = (Stakeholder)stakeholder.Clone();
Proveedor clonedProveedor = (Proveedor)proveedor.Clone();



clonedStakeholder.Id = 6;
clonedStakeholder.Draw();
clonedProveedor.Id = 7;
clonedProveedor.Draw();

Console.WriteLine();
Console.WriteLine("Se verifica que el Objeto original del Stakeholder y del Proveedororigina no fue modificado");
stakeholder.Draw();
proveedor.Draw();