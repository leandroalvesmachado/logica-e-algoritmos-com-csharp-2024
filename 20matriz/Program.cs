// Matriz
string[,] dados = {
    {"Ralf", "Curitiba"},
    {"Juliana", "Campinas"},
    {"Marcela", "Londrina"}
};

// Exibir dados
Console.WriteLine(dados); // System.String[,]

// Linha 0, Posição 0
Console.WriteLine(dados[0,0]); // Ralf

foreach (string dado in dados)
{
    Console.WriteLine(dado);
    // Ralf
    // Curitiba
    // Juliana
    // Campinas
    // Marcela
    // Londrina
}