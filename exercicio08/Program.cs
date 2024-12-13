/*
    Atividade 08
    Peça três lados de um triângulo e retorne o seu tipo:

    Equilátero: todos os lados congruentes (iguais)
    Isósceles: dois lados congruentes (iguais)
    Escaleno: todos os lados com medidas distintas
*/

// Obter o lado direito
Console.WriteLine("Informe o lado direito");
int ladoDireito = Convert.ToInt16(Console.ReadLine());

// Obter o lado inferior
Console.WriteLine("Informe o lado inferior");
int ladoInferior = Convert.ToInt16(Console.ReadLine());

// Obter o lado esquerdo
Console.WriteLine("Informe o lado esquerdo");
int ladoEsquerdo = Convert.ToInt16(Console.ReadLine());

// Verificação
if (ladoDireito == ladoInferior && ladoInferior == ladoEsquerdo)
{
    Console.WriteLine("Equilátero");
}
else if (ladoDireito == ladoInferior || ladoDireito == ladoEsquerdo || ladoInferior == ladoEsquerdo)
{
    Console.WriteLine("Isósceles");
}
else
{
    Console.WriteLine("Escaleno");
}