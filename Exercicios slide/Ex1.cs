

Console.WriteLine("Gestão de pessoas:");

int idade;
float total = 0, qtaA = 0, qtaB = 0, qtaC = 0, qtaD = 0, qtaE = 0;


 Console.WriteLine("Digite a idade: ");

while (true)
{

    idade = int.Parse(Console.ReadLine());

    if (idade < 0)
    {
        Console.WriteLine("Idade inválida!");
        continue;
    }

    if (idade == 0)
    {
        break;
    }

    switch (idade)
    {
        case < 16:
            qtaA++;
            total++;
            break;
        case >= 16 and < 31:
            qtaB++;
            total++;
            break;
        case >= 31 and < 46:
            qtaC++;
            total++;
            break;
        case >= 46 and < 61:
            qtaD++;
            total++;
            break;
        case >= 61:
            qtaE++;
            total++;
            break;

    }
}

Console.WriteLine($"A: {(qtaA / total) * 100:f2}%");
Console.WriteLine($"B: {(qtaB / total) * 100:f2}%");
Console.WriteLine($"C: {(qtaC / total) * 100:f2}%");
Console.WriteLine($"D: {(qtaD / total) * 100:f2}%");
Console.WriteLine($"E: {(qtaE / total) * 100:f2}%");






