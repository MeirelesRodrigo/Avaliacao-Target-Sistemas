class program
{
    static void Main()
    {
        int INDICE = 13;
        int SOMA = 0;
        int K = 0;

        while (K < INDICE)
        {
            K++;
            SOMA = SOMA + K;
        }
        Console.WriteLine($"O valor final de SOMA é: {SOMA}");
    }
}