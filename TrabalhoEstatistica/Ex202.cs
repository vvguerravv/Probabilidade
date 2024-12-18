namespace TrabalhoEstatistica;

public class Ex202
{
    public Ex202(){}

    public void calcula()
    {
        Random random = new Random();
        int totalDefeituosos = 0;
        int defeituososDeA = 0;

        // Simulação de 1.000.000 retiradas
        for (int i = 0; i < 1000000; i++)
        {
            // Sorteio da máquina: 0 para A, 1 para B
            int maquina = random.Next(0, 2);

            if (maquina == 0) // Parafuso produzido por A
            {
                // Probabilidade de ser defeituoso: 15%
                if (random.NextDouble() < 0.15)
                {
                    totalDefeituosos++;
                    defeituososDeA++;
                }
            }
            else // Parafuso produzido por B
            {
                // Probabilidade de ser defeituoso: 5%
                if (random.NextDouble() < 0.05)
                {
                    totalDefeituosos++;
                }
            }
        }

        // Probabilidade condicional: P(A | D)
        double probabilidade = (double)defeituososDeA / totalDefeituosos;

        Console.WriteLine($"Probabilidade de o parafuso defeituoso ser da máquina A: {probabilidade:P2}");
    }
}