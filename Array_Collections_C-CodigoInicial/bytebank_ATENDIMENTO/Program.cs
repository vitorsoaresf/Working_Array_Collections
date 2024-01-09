using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;

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
    ListaDeContasCorrentes listaDeContas = new();
    
    var conta1 = new ContaCorrente(874, "234234234-A");
    conta1.Saldo = 100;

    var conta2 = new ContaCorrente(875, "234234343-B");
    conta2.Saldo = 50;

    var conta3 = new ContaCorrente(876, "234234123-C");
    conta3.Saldo = 80;

    var conta4 = new ContaCorrente(877, "234234123-D");
    conta3.Saldo = 80;

    var conta5 = new ContaCorrente(878, "234234123-E");
    conta3.Saldo = 80;

    listaDeContas.AdicionarConta(conta1);
    listaDeContas.AdicionarConta(conta2);
    listaDeContas.AdicionarConta(conta3);
    listaDeContas.AdicionarConta(conta4);
    listaDeContas.AdicionarConta(conta5);
    // listaDeContas.MostrarContas();

    listaDeContas.MostraMaiorContaDaLista();
}


Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

// TestaMediana(amostra);

TestaArrayDeContasCorrentes();

