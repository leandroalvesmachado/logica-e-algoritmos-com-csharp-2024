/*
    Atividade 06
    Peça um número inteiro, retorne se é um número positivo, neutro ou negativo

    Exemplos:
    -5: Negativo
    34: Positivo
    -3: Negativo
     0: Neutro
*/

// Obter número
Console.WriteLine("Informe o número");
int numero = Convert.ToInt16(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine("Número positivo");
}
else if (numero == 0)
{
    Console.WriteLine("Número neutro");
}
else
{
    Console.WriteLine("Número negativo");
}