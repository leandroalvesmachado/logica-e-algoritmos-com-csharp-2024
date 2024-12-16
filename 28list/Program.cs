// List
// Tamanho ilimitado, mas com tipo definido
// Mais performance que o ArrayList, pois os tipos já estão definidos
List<string> nomes = new List<string>();

// Adicionar nomes
nomes.Add("Ralf");
nomes.Add("Estella");
nomes.Add("Stephanie");

// Laço de repetição
for(int indice = 0; indice < nomes.Count; indice++)
{
    Console.WriteLine(nomes[indice]);
}
