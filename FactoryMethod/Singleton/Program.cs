using Singleton;


GeneradorInformesSingleton instance1 = GeneradorInformesSingleton.GetInstance();
Console.WriteLine($"Estos son los datos del informe para la instancia 1: {instance1.Data} ");
Console.WriteLine();

GeneradorInformesSingleton instance2 = GeneradorInformesSingleton.GetInstance();
Console.WriteLine($"Estos son los datos del informe para la instancia 2: {instance2.Data} ");
Console.WriteLine();


//Validar Instancia
if (instance1 == instance2)
{
    Console.WriteLine("Singleton funciona, ambas variables contienen la misma instancia.");
}
else
{
    Console.WriteLine("Error del singleton, las variables contienen instancias diferentes.");
}