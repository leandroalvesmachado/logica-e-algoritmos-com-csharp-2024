/*
    Atividade 02
    Peça um número e retorne se é par ou ímpar.
    DICA: Para sabermos de um número é par ou ímpar, será necessário
    utilizarmos o módulo (resto da divisão -> %)
*/

// Obter o número
Console.WriteLine("Informe o número");
int numero = Convert.ToInt16(Console.ReadLine());

// Verificação
if (numero % 2 == 0)
{
    Console.WriteLine("Número é Par");
}
else
{
    Console.WriteLine("Número é Ímpar");
}

// Outra forma
Console.WriteLine(numero % 2 == 0 ? "Número é Par" : "Número é Ímpar");