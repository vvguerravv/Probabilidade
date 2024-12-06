namespace TrabalhoEstatistica;

public class Ex50
{
    public Ex50()
    { }

    public void calcula()
    {
        // Função para calcular a permutação P(n, k)
        static long Permutacao(int n, int k)
        {
            long result = 1;
            for (int i = 0; i < k; i++)
                result *= (n - i);
            return result;
        }

        // Total de times
        int totalTimes = 20;
        int posicoes = 3;

        // Calcula o número de permutações
        long totalResultados = Permutacao(totalTimes, posicoes);

        // Exibe o resultado
        Console.WriteLine($"O número total de resultados possíveis para os três primeiros lugares é: {totalResultados}\n");
    }
}