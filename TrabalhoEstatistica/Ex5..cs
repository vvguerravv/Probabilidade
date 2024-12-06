namespace TrabalhoEstatistica;

class Ex5
{
    /*Um grupo consta de 20 pessoas, das quais 5 matemáticos. De quantas formas podemos formar comissões de 10 pessoas de modo que:
    a.) nenhum membro seja matemático?*/

    public Ex5()
    {}

    public void calcula()
    {
        // Total de números de 4 algarismos possíveis (9 opções por posição)
        int totalPossiveis = (int)Math.Pow(9, 4);

        // Números com todos os algarismos diferentes
        int Diferentes = 9 * 8 * 7 * 6;

        // Números com pelo menos dois algarismos iguais
        int DoisIguais = totalPossiveis - Diferentes;

        Console.WriteLine($"Total de números com pelo menos dois algarismos iguais: {DoisIguais}");
    }
}