// Referenciar o System.Collections para termos acesso ao ArrayList
using System.Collections;

// Criar vetor vazio
// tamanho limitado e do mesmo tipo
string[] vetor = new string[10];

// Criando arrayList, não tem limitação de tamanho
// Pode armazenar vários tipos diferentes de dados
ArrayList lista = new ArrayList();

// adicionar valores diferentes ao ArrayList
lista.Add("Ralf");
lista.Add(30);
lista.Add(7.5);
lista.Add(true);

// Listar ArrayList
foreach (var l in lista)
{
    Console.WriteLine(l);
}

// [PRINCIPAIS COMANDOS PARA UTILIZAR NO ARRAYLIST]

// - ArrayList.Add(object value): Adiciona um objeto ao final do ArrayList.

// - ArrayList.AddRange(ICollection c): Adiciona os elementos de uma coleção ao final do ArrayList.

// - ArrayList.Insert(int index, object value): Insere um elemento em uma posição específica do ArrayList.

// - ArrayList.InsertRange(int index, ICollection c): Insere os elementos de uma coleção em uma posição específica do ArrayList.

// - ArrayList.Remove(object obj): Remove a primeira ocorrência de um objeto específico do ArrayList.

// - ArrayList.RemoveAt(int index): Remove o elemento na posição especificada do ArrayList.

// - ArrayList.RemoveRange(int index, int count): Remove um número específico de elementos a partir de uma posição específica do ArrayList.

// - ArrayList.Clear(): Remove todos os elementos do ArrayList.

// - ArrayList.Contains(object obj): Determina se o ArrayList contém um valor específico.

// - ArrayList.IndexOf(object obj): Retorna o índice da primeira ocorrência de um objeto específico no ArrayList.

// - ArrayList.LastIndexOf(object obj): Retorna o índice da última ocorrência de um objeto específico no ArrayList.

// - ArrayList.Count: Retorna o número de elementos contidos no ArrayList.

// - ArrayList.Capacity: Obtém ou define o número de elementos que o ArrayList pode conter.

// - ArrayList.TrimToSize(): Define a capacidade do ArrayList para ser igual ao número de elementos presentes nele.