using Desafio3.Models;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string dados = @"..\..\..\dados.json";

        string json = File.ReadAllText(dados);
        var dadosJson = JsonConvert.DeserializeObject<List<Faturamento>>(json);

        var faturamento = dadosJson.Where(x => x.Valor != 0);


        var menorFaturamento = new Faturamento
        {
            DiaMes = faturamento?.FirstOrDefault().DiaMes ?? 0,
            Valor = faturamento?.FirstOrDefault().Valor ?? 0
        };

        var maiorFaturamento = new Faturamento
        {
            DiaMes = faturamento?.FirstOrDefault().DiaMes ?? 0,
            Valor = faturamento?.FirstOrDefault().Valor ?? 0
        };

        foreach (var item in faturamento)
        {
            if (item.Valor < menorFaturamento.Valor)
            {
                menorFaturamento = item;
            }

            if (item.Valor > maiorFaturamento.Valor)
            {
                maiorFaturamento = item;
            }
        }

        double media = faturamento.Sum(x => x.Valor) / faturamento.Count();

        Console.WriteLine($"Menor faturamento {menorFaturamento.DiaMes} - {menorFaturamento.Valor}");
        Console.WriteLine($"Maior faturamento {maiorFaturamento.DiaMes} - {maiorFaturamento.Valor}");
        Console.WriteLine($"Media {media}");
    }
}