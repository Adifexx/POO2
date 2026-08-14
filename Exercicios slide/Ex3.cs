Console.WriteLine("Digite a temperatura: ");

int dias = 0;
float temp, tempTotal = 0;

while (dias < 16)
{
    temp = float.Parse(Console.ReadLine());

    if (temp < 28)
    {
        Console.WriteLine("temperatura invalida");
        continue;
    }

    dias++;
    tempTotal += temp;

}

Console.WriteLine($"Temperatura Media: {tempTotal/dias}");