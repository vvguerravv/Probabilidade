namespace TrabalhoEstatistica;

public class Ex202
{
    public Ex202(){}

    public void calcula()
    {
        // Probabilidades fornecidas
        double P_D_A = 0.15;  // Probabilidade de defeito dado que foi produzido pela máquina A
        double P_D_B = 0.05;  // Probabilidade de defeito dado que foi produzido pela máquina B
        double P_A = 0.5;      // Probabilidade de ser da máquina A
        double P_B = 0.5;      // Probabilidade de ser da máquina B

        // Probabilidade total de defeito
        double P_D = (P_D_A * P_A) + (P_D_B * P_B);

        // Aplicando o Teorema de Bayes para encontrar P(A|D)
        double P_A_given_D = (P_D_A * P_A) / P_D;

        // Exibindo o resultado
        Console.WriteLine($"A probabilidade de que o parafuso defeituoso tenha sido produzido pela máquina A é: {P_A_given_D:P2}");
    }
}