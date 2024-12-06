namespace TrabalhoEstatistica;

public class Ex42
{
    public Ex42() {}

    public void calcula()
    {
        // Função para calcular o fatorial de um número
        static long Fatorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;
            return result;
        }

        // Função para calcular combinações C(n, k)
        static long Combinacao(int n, int k)
        {
            return Fatorial(n) / (Fatorial(k) * Fatorial(n - k));
        }

        // Cenário 1: Casal participa
        int totalSemCasal = 8;
        int vagasRestantes = 2;
        long caso1 = Combinacao(totalSemCasal, vagasRestantes);

        // Cenário 2: Casal não participa
        int totalApenasSemCasal = 8;
        int totalVagas = 4;
        long caso2 = Combinacao(totalApenasSemCasal, totalVagas);

        // Total de formas
        long totalFormas = caso1 + caso2;

        Console.WriteLine($"Total de formas de formar o grupo: {totalFormas}\n");
    }
}