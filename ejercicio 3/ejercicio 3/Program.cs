using System;

Console.WriteLine("\nHolis");
try
{
    Console.WriteLine("\n Ingrese la cantidad de kilometros conducidos");
    int kilometros = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n Ingrese la cantidad de litros de nafta:");
    int nafta = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n Kilometros/litro:" + kilometros/nafta);
}
catch
{
    Console.WriteLine("\n No se puede dividir en 0 ni se aceptan letras");
}