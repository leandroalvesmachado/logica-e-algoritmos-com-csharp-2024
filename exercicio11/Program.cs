/*
    Atividade 11

    Peça um número inteiro, em seguida retorne a tabuada.
*/

// Obter o número
Console.WriteLine("Informe o número");
int numero = Convert.ToInt16(Console.ReadLine());

for (int indice = 1; indice <= 10; indice++)
{
    Console.WriteLine($"{numero} x {indice} = {numero * indice}");
}