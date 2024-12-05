using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("-----------------");
        Console.WriteLine("");
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();
        string[] palavras = frase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int numeroDePalavras = palavras.Length;
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine($"A frase contém {numeroDePalavras} palavras.");
    }
}

