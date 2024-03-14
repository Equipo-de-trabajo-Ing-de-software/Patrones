
using Prototype;



Stakeholder stakeholder = new Stakeholder {} ;
Console.WriteLine();

Proveedor proveedor = new Proveedor {};


//Draw original Shapes

stakeholder.Draw();


proveedor.Draw();

Console.WriteLine();
//hacer los clones

Stakeholder clonedStakeholder = (Stakeholder)stakeholder.Clone();
Proveedor clonedProveedor = (Proveedor)proveedor.Clone();


Console.WriteLine("Clonar Datos del Stakeholder:");
clonedStakeholder.Name = "Pedro Arrieta";
clonedStakeholder.Phone = "12345678";
clonedStakeholder.Email = "pedro@gmail.com";
clonedStakeholder.Draw();
Console.WriteLine();

Console.WriteLine("Clonar Datos del  Proveedor:");
clonedProveedor.Name= "Empreza X";
clonedProveedor.Phone = "698740";
clonedProveedor.Email = "empresax@gmail.com";
clonedProveedor.Draw();

Console.WriteLine();
Console.WriteLine("Se verifica que el Objeto original del Stakeholder y del Proveedor no sean modificado");
stakeholder.Draw();
proveedor.Draw();