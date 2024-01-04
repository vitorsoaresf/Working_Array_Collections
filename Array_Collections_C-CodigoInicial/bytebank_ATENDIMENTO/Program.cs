using bytebank.Modelos.Conta;

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

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[] { "Ana", "João", "Pedro", "Maria", "Cesar" };

    Console.WriteLine("Digite a palavra a ser encontrada: ");
    string busca = Console.ReadLine()!;

    if (arrayDePalavras.Contains(busca))
    {
        Console.WriteLine("A palavra foi encontrada\n");
    }
    else
    {
        Console.WriteLine("A palavra não foi encontrada\n");
    }
}

void TestaMediana(Array array)
{
    if((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para calculo da mediana está vazio ou nulo");
        return;
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio -1]) / 2;

    Console.WriteLine($"A mediana é = {mediana}");
}


void TestaArrayDeContasCorrentes()
{
    ContaCorrente[] listaDeContas = new ContaCorrente[]
    {
        new ContaCorrente(874,"234234234-A"),
        new ContaCorrente(874, "234234343-B"),
        new ContaCorrente(874, "234234123-C")
    };
    
    for (int i = 0; i < listaDeContas.Length; i++)
    {
        ContaCorrente contaAtual = listaDeContas[i];
        Console.WriteLine($"Índice {i} - Conta: {contaAtual.Conta}");
    }
}


Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

// TestaMediana(amostra);

TestaArrayDeContasCorrentes();

