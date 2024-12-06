namespace TrabalhoEstatistica;

public class Ex149
{
    public Ex149(){}

    public void calcular()
    {
        // Probabilidades iniciais
        double probMasculino = 0.4;
        double probFeminino = 0.6;
        double probDengueMasculino = 0.5;
        double probDengueFeminino = 0.3;

        // Cálculo da probabilidade total
        double probDengue = (probDengueMasculino * probMasculino) + (probDengueFeminino * probFeminino);

        // Exibe o resultado
        Console.WriteLine($"A probabilidade de uma pessoa escolhida aleatoriamente já ter tido dengue é: {probDengue:P2}");
    }
}