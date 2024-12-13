/*
    Atividade 07
    Peça três números inteiros e retorne qual deles é o menor
*/

// Obter primeiro número
Console.WriteLine("Informe o primeiro número");
int numero1 = Convert.ToInt16(Console.ReadLine());

// Obter segundo número
Console.WriteLine("Informe o segundo número");
int numero2 = Convert.ToInt16(Console.ReadLine());

// Obter terceiro número
Console.WriteLine("Informe o terceiro número");
int numero3 = Convert.ToInt16(Console.ReadLine());

// Verificação
int menor = numero1;

if (numero2 < menor)
{
    menor = numero2;
}

if (numero3 < menor)
{
    menor = numero3;
}

// Retorno
Console.WriteLine($"O menor número é {menor}");