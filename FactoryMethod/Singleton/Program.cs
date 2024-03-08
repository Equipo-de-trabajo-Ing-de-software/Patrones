using Singleton;

StakeholderSingleton instance1 = StakeholderSingleton.GetInstance();
StakeholderSingleton instance2 = StakeholderSingleton.GetInstance();

      

while (true)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Por favor elija el tipo de Usuario: (1) Stakeholder, (2) Proveedor, (3) Salir");
        Console.WriteLine();
    int opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
  
            Console.WriteLine($"El Id del Stakeholder es: {instance1.Id} y su password es: {instance1.Password}");
            Console.WriteLine();
            break;
           
        case 2:
            Console.WriteLine($"El Id del Proveedor es: {instance2.Id} y su password es: {instance2.Password}");
            break;
        case 3:
            return; // salir del programa
        default:
            Console.WriteLine("Opción no válida");
            break;
    }

    //
    if (instance1 == instance1)
    {
        Console.WriteLine("Singleton funciona, ambas variables contienen la misma instancia.");
    }
    else
    {
        Console.WriteLine("Error del singleton, las variables contienen instancias diferentes.");
    }
}

