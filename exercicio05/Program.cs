/*
    Atividade 05
    Peça um ano e retorne se é bissexto ou não

    Dica: Um ano bissexto ocorre a cada 4 anos
*/

// Obter o ano
Console.WriteLine("Informe o ano");
int ano = Convert.ToInt16(Console.ReadLine());

// Verificação
Console.WriteLine(ano % 4 == 0 ? "Ano bissexto" : "Ano não bissexto");