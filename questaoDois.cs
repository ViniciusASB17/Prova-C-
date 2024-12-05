using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("Digite a primeira data: (Formato: dd/MM/yyyy):");
        string primeiraDataInput = Console.ReadLine();
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("Digite a segunda data: (formato: dd/MM/yyyy):");
        string segundaDataInput = Console.ReadLine();
        DateTime primeiraData;
        DateTime segundaData;
        bool primeiraDataValida = DateTime.TryParseExact(primeiraDataInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out primeiraData);
        bool segundaDataValida = DateTime.TryParseExact(segundaDataInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out segundaData);
        if (!primeiraDataValida || !segundaDataValida)
        {
            Console.WriteLine("formato inválido o formato deve ser dd/MM/yyyy.");
            return;
        }
        TimeSpan diferenca = segundaData - primeiraData;
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine($"A quantidade de dias {primeiraData.ToString("dd/MM/yyyy")} e {segundaData.ToString("dd/MM/yyyy")} é: {Math.Abs(diferenca.Days)} dias.");
    }
}
