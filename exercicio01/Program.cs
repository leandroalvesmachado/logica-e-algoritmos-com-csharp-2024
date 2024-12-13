/*
    Atividade 01
    Peça dois números inteiros, se forem iguais realize a soma, se forem diferentes realize a multiplicação.
*/

// Obter o primeiro valor
Console.WriteLine("Informe o primeiro número");
int numero1 = Convert.ToInt16(Console.ReadLine());

// Obter o segundo valor
Console.WriteLine("Informe o segundo número");
int numero2 = Convert.ToInt16(Console.ReadLine());

// Condicional
if (numero1 == numero2)
{
    Console.WriteLine($"Soma: {numero1 + numero2}");
}
else
{
    Console.WriteLine($"Multiplicação: {numero1 * numero2}");
}
