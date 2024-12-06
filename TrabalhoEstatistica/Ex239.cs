namespace TrabalhoEstatistica;

public class Ex239
{
    public Ex239(){}

    public void calcula()
    {
        // Probabilidades fornecidas
        double P_A_C = 0.90;  // Probabilidade de alcançar a cota dado que passou pelo curso
        double P_A_N = 0.65;  // Probabilidade de alcançar a cota dado que não passou pelo curso
        double P_C = 0.50;     // Probabilidade de ter passado pelo curso
        double P_N = 0.50;     // Probabilidade de não ter passado pelo curso

        // Probabilidade total de alcançar a cota
        double P_A = (P_A_C * P_C) + (P_A_N * P_N);

        // Aplicando o Teorema de Bayes para encontrar P(C|A)
        double P_C_given_A = (P_A_C * P_C) / P_A;

        // Exibindo o resultado
        Console.WriteLine($"A probabilidade de que o operador tenha passado pelo curso, dado que alcançou sua cota, é: {P_C_given_A:P2}");
    }
}