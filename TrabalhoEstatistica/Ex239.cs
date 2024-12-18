namespace TrabalhoEstatistica;

public class Ex239
{
    public Ex239(){}

    public void calcula()
    {
        Random random = new Random();
        int totalExperimentos = 1000000;
        int operadoresComCursoQueAlcancaram = 0;
        int operadoresQueAlcancaram = 0;

        for (int i = 0; i < totalExperimentos; i++)
        {
            // Determinar se o operador fez o curso (50% de chance)
            bool fezCurso = random.NextDouble() < 0.5;

            // Probabilidade de alcançar a cota dependendo de ter feito o curso
            double probabilidadeDeAlcancar = fezCurso ? 0.90 : 0.65;

            // Determinar se o operador alcançou a cota
            if (random.NextDouble() < probabilidadeDeAlcancar)
            {
                operadoresQueAlcancaram++;

                if (fezCurso)
                {
                    operadoresComCursoQueAlcancaram++;
                }
            }
        }

        // Calculando a probabilidade de que o operador tenha feito o curso, dado que alcançou a cota
        double probabilidade = (double)operadoresComCursoQueAlcancaram / operadoresQueAlcancaram;

        Console.WriteLine($"Probabilidade de que o operador tenha feito o curso, dado que alcançou a cota: {probabilidade:P2}");
    }
}