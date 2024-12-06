namespace TrabalhoEstatistica;

public class Ex174
{
    public Ex174(){}

    public void calcular()
    {
        // Parte (a): Probabilidade de cores diferentes
        int totalBolas = 20;
        int bolasVerdes = 10;
        int bolasAmarelas = 10;

        // Total de combinações
        double totalCombinacoes = Combinacao(totalBolas, 2);

        // Combinações de cores diferentes
        double combinacoesCoresDiferentes = bolasVerdes * bolasAmarelas;
        double probabilidadeCoresDiferentes = combinacoesCoresDiferentes / totalCombinacoes;

        Console.WriteLine($"a) Probabilidade de as duas bolas terem cores diferentes: {probabilidadeCoresDiferentes:P2}");

        // Parte (b): Probabilidade condicional
        int bolasAmarelasPares = 5;
        double probabilidadeBC_A = (double)bolasAmarelasPares / (totalBolas - 1);
        Console.WriteLine($"b) P((B ∩ C) | A): {probabilidadeBC_A:P2}");
    }

    // Função para calcular combinações C(n, k)
    static double Combinacao(int n, int k)
    {
        double resultado = 1;
        for (int i = 0; i < k; i++)
            resultado *= (n - i);
        for (int i = 1; i <= k; i++)
            resultado /= i;
        return resultado;
    }
    }