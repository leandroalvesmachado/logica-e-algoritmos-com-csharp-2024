/*
    Atividade 10
    
    Peça um valor monetário, em seguida escolha o tipo de conversão:
    
    Real para Dólar
    Dólar para Real

    Retorne o valor convertido
*/

// Obter o valor
Console.WriteLine("Informe o valor");
double valor = Convert.ToDouble(Console.ReadLine());

// Selecionar o tipo de conversão
Console.WriteLine("Selecione o tipo de conversão:");
Console.WriteLine("1) Real para Dólar");
Console.WriteLine("2) Dólar para Real");
int tipo = Convert.ToInt16(Console.ReadLine());

// Verificação
if (tipo == 1)
{
    Console.WriteLine($"Dólar: $ {valor/5}");
}
else if (tipo == 2)
{
    Console.WriteLine($"Real: R$ {valor*5}");
}
else
{
    Console.WriteLine("Tipo não encontrado");
}