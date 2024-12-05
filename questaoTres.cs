using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> dddCidades = new Dictionary<int, string>()
        {
            { 34, "Araxa" },
            { 62, "Goiania" },
            { 11, "São Paulo" },
            { 21, "Rio de Janeiro" },
            { 13, "Amapa" },
            { 19, "Campinas" },
            { 28, "Vitória" },
            { 30, "Belo Horizonte" }
        };
        Console.WriteLine("Digite um código DDD:");
        int ddd = int.Parse(Console.ReadLine());
        if (dddCidades.ContainsKey(ddd))
        {
            Console.WriteLine(dddCidades[ddd]);
        }
        else
        {
            Console.WriteLine("DDD não cadastrado");
        }
    }
}
