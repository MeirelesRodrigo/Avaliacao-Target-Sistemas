class Program
{
    static void Main()
    {
        var faturamento = new Dictionary<string, double>
        {
            { "SP",  67836.43 },
            { "RJ", 36678.66 },
            { "MG",  29229.88 },
            { "ES",  27165.48},
            { "OUTROS",  19849.53}
        };
        var faturamentoTotal = faturamento.Sum(x => x.Value);

        var faturamentoPercentual = new Dictionary<string, double>();

        foreach (var item in faturamento)
        {
            faturamentoPercentual.Add(item.Key, (item.Value * 100) / faturamentoTotal);
        }

        foreach (var item in faturamentoPercentual)
        {
            Console.WriteLine($"{item.Key} - {item.Value:F2} %");
        }
    }
}
