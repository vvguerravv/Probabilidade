namespace TrabalhoEstatistica;

public class Ex131
{
    public void calcula()
    {
        // Função para calcular combinações C(n, k)
        static long Combinacao(int n, int k)
        {
            long result = 1;
            for (int i = 0; i < k; i++)
                result *= (n - i);
            for (int i = 1; i <= k; i++)
                result /= i;
            return result;
        }

        // Total de dezenas e marcadas no volante
        int totalDezenas = 100;
        int marcadas = 10;
        int quina = 5;

        // Cálculo de combinações
        long totalCombinacoes = Combinacao(totalDezenas, quina);
        long combinacoesFavoraveis = Combinacao(marcadas, quina);

        // Probabilidade
        double probabilidade = (double)combinacoesFavoraveis / totalCombinacoes;

        // Exibe o resultado
        Console.WriteLine($"A probabilidade de acertar a quina ao marcar 10 dezenas é: {probabilidade:P10}");
    }
}