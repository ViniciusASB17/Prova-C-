using System;

class Program
{
    static void Main()
    {
        // Leitura do valor inteiro
        Console.WriteLine("---------------------------");
        Console.WriteLine("");
        Console.WriteLine("- Digite um valor inteiro:");
        int valor = int.Parse(Console.ReadLine());
        int valorOriginal = valor;
        int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
        Console.WriteLine(valorOriginal);
        foreach (int nota in notas)
        {
            int quantidadeNotas = valor / nota;
            valor %= nota;
            Console.WriteLine("---------------------------");
            Console.WriteLine("");
            Console.WriteLine($"{quantidadeNotas} nota(s) de R$ {nota},00");
        }
    }
}
