/*
    Atividade 13

    Peça diversos números inteiros, até que seja informado o número zero.

    Quando sair da estrutura de repetição, exiba a soma dos valores informados.

    Exemplo: 7,8, 10 e 0.
    A soma será 25.
*/

// Variáveis
int numero = 0;
int soma = 0;

// Estrutura de repetição
do
{
    // Perguntar um número
    Console.WriteLine("Qual número deseja informar?");
    numero = Convert.ToInt16(Console.ReadLine());

    // Somar
    soma += numero;
} while (numero != 0);

// Exibir a soma
Console.WriteLine($"A soma dos valores é {soma}");