/*
    Atividade 03
    Peça duas notas, em seguida realize a média e retorne a situação

    7 - 10:  Aprovado
    5 - 6.9: Recuperação
    0 - 4.9: Reprovado
*/

// Obter a primeira nota
Console.WriteLine("Informe a primeira nota");
double nota1 = Convert.ToDouble(Console.ReadLine());

// Obter a segunda nota
Console.WriteLine("Informe a segunda nota");
double nota2 = Convert.ToDouble(Console.ReadLine());

// Realizar a média
double media = (nota1 + nota2) / 2;

// Situação
if (media >= 7)
{
    Console.WriteLine($"Aprovado com média {media}");
}
else if (media >= 5 && media <= 6.9)
{
    Console.WriteLine($"Recuperação com média {media}");
}
else
{
    Console.WriteLine($"Reprovado com média {media}");
}
