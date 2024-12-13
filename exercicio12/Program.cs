/*
    Atividade 12

    Peça um nome até que seja informado o termo "sair"
*/

// Variável
string ?nome;

do
{
    // Obter um nome
    Console.WriteLine("Informe um nome");
    nome = Console.ReadLine(); 
} while (nome != "sair");