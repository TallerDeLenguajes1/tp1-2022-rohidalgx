
using System;


Console.WriteLine("\nHolis");
try
{
    Console.WriteLine("\n Ingrese un numero entero:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n Ingrese otro numero entero:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n Resultado de la division:" + num1/num2);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: ¡no se puede dividir en cero!");
}
catch (FormatException)
{
    Console.WriteLine("¡Error de formato (ingrese un número válido)!");
}
catch (Exception e)
{
    Console.WriteLine($"Error encontrado: {e.Message}");
}