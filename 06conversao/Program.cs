// Obter o primeiro número
Console.WriteLine("Informe um número");

// Console.ReadLine o retorno é sempre uma string, precisa converter a string para int
int numero1 = Convert.ToInt16(Console.ReadLine());

// Obter o segundo número
Console.WriteLine("Informe outro número");

// Console.ReadLine o retorno é sempre uma string, precisa converter a string para int
int numero2 = Convert.ToInt16(Console.ReadLine());

// Realizar a soma
Console.WriteLine($"A soma é: {numero1 + numero2}");