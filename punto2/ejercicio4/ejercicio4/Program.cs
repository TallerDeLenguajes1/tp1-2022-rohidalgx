
try
{
    var raizApi = ServicioConexion.VerResultadosApi();
    Console.WriteLine("Información Provincias");

    if (raizApi?.provincias == null) return;

    foreach (var provincia in raizApi.provincias)
    {
        Console.WriteLine("ID: " + provincia.id);
        Console.WriteLine("Nombre: " + provincia.nombre);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

