Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

void TestaArrayInt()
{
    int[] idades = new int[5] { 30, 30, 10, 12, 13};

    Console.WriteLine( $"Tamanho do arrray: {idades.Length}");

    foreach(int idade in idades)
    {
        Console.WriteLine($"idade: {idade}");
    }

    Console.WriteLine($"A médias das idade é: {idades.Average()}");
}

TestaArrayInt();