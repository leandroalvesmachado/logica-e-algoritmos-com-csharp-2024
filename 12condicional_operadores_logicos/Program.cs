// Variáveis
double valor = 500;
string pagamento = "à vista";

if (valor >= 100 && pagamento == "à vista")
{
    // Desconto de 10%! Total a pagar R$450
    Console.WriteLine($"Desconto de 10%! Total a pagar R${valor*0.90}");
}
else
{
    Console.WriteLine($"O total da compra é R${valor}");
}
