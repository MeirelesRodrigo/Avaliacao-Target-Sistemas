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
            DiaMes = faturamento?.FirstOrDefault()?.DiaMes ?? 0,
            Valor = faturamento?.FirstOrDefault()?.Valor ?? 0
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

        Console.WriteLine("===== Relatório de Faturamento Mensal =====");
        Console.WriteLine($"Menor faturamento: Dia {menorFaturamento.DiaMes} - R$ {menorFaturamento.Valor.ToString("N2")}");
        Console.WriteLine($"Maior faturamento: Dia {maiorFaturamento.DiaMes} - R$ {maiorFaturamento.Valor.ToString("N2")}");
        Console.WriteLine($"Média mensal: R$ {media.ToString("N2")}");
        Console.WriteLine("===========================================");
    }
}