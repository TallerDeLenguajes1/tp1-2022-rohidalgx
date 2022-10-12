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
catch (FormatException)
{
    Console.WriteLine("Error: ingrese un número válido (error de formato)");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Error: ¡la cantidad de litros consumidos no puede ser cero!");
}
catch (OverflowException)
{
    Console.WriteLine("Error: no se puede trabajar con números de gran magnitud.");
}
catch (Exception e)
{
    Console.WriteLine($"Error: {e.Message}");
}