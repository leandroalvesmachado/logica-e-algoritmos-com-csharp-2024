/*
    Atividade 09

    Peça uma hora referente ao horário de Brasília (0 até 23).
    Em seguida liste três cidades e peça para selecionar uma.
    Tendo essas duas informações, retorne o horário da cidade selecionada.

    Algumas cidades e seus respectivos fusos horários:
    Tóquio: +12
    Lisboa: +4
    Paris: +5
*/


// Obter o horário
Console.WriteLine("Informe a hora em Brasília");
int hora = Convert.ToInt16(Console.ReadLine());


// Selecionar cidade
Console.WriteLine("Selecione uma cidade: ");
Console.WriteLine("1) Tóquio");
Console.WriteLine("2) Lisboa");
Console.WriteLine("3) Paris");
int cidade = Convert.ToInt16(Console.ReadLine());

// Verificação
switch (cidade)
{
    case 1:
        hora += 12;
        break;
    case 2:
        hora += 4;
        break;
    case 3:
        hora += 5;
        break;
    default:
        break;
}

// Retorno
if (hora > 23)
{
    Console.WriteLine(hora - 24);
}
else
{
    Console.WriteLine(hora);
}