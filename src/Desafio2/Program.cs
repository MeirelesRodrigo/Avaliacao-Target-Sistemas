class Program
{
    static void Main()
    {
        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (isFibonacci(number))
            {
                Console.WriteLine($"O número {number} pertence a sequência Fibonacci");
            }
            else
            {
                Console.WriteLine($"O número {number} não pertence a sequência Fibonacci");

            }
        }
        else
        {
            Console.WriteLine("Erro: Por favor, digite um número inteiro válido.");
        }


        static bool isFibonacci(int num)
        {
            if (num == 0 || num == 1) return true;

            int a = 0, b = 1, soma = 0;

            while (soma < num)
            {
                soma = a + b;
                a = b;
                b = soma;

                if (soma == num) return true;
            }

            return false;
        }
    }
}