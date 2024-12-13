try
{
    Console.WriteLine("Informe um número");
    int numero = Convert.ToInt16(Console.ReadLine());
}
catch (Exception e)
{
    Console.WriteLine($"Houve uma falha: {e.Message}");
}
finally
{
    Console.WriteLine("Sistema finalizado");
}
