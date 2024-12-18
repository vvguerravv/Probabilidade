namespace TrabalhoEstatistica;

public class Ex149
{
    public Ex149(){}

    public void calcular()
    {
        /* Probabilidades iniciais:
        double probMasculino = 0.4;
        double probFeminino = 0.6;
        double probDengueMasculino = 0.5;
        double probDengueFeminino = 0.3;*/

        Random random = new Random();

        double dengueFeminino = 0.6 * 0.3;
        double dengueMasculino = 0.4 * 0.5;

        int contaProb = 0;

        for(int i = 0;i < 1000000;i++){
            if(dengueFeminino + dengueMasculino >= random.NextDouble()){
                contaProb++;
            }
        }

        // Exibe o resultado
        Console.WriteLine("A probabilidade de uma pessoa escolhida aleatoriamente já ter tido dengue é: " + (double) contaProb * 100 / 1000000 + "%");
    }
}