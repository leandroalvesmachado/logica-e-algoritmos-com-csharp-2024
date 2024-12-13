/*
    Atividade 14

    Peça dois números, em seguida exiba os valores entre os números informados.

    Exemplo: Se informados 2 e 5, o retorno será 2, 3, 4, 5.
*/

// Obter o primeiro número
Console.WriteLine("Informe o primeiro número");
int numero1 = Convert.ToInt16(Console.ReadLine());

// Obter o segundo número
Console.WriteLine("Informe o segundo número");
int numero2 = Convert.ToInt16(Console.ReadLine());

// Estrutura de repetição
if (numero1 < numero2)
{    
    while (numero1 <= numero2)
    {
        Console.WriteLine(numero1);

        numero1++;
    }   
}
else
{   
    while (numero1 >= numero2)
    {
        Console.WriteLine(numero1);

        numero1--;
    }
}