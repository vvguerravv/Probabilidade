namespace TrabalhoEstatistica;

public class Ex135
{
    public Ex135(){}

    public void calcular()
    {
                // Espaço amostral inicial
                string[] espacoAmostral = { "CCC", "CCK", "CKC", "KCC", "KKC", "KCK", "CKK", "KKK" };
                Console.WriteLine("a) Espaço amostral:");
                Console.WriteLine(string.Join(", ", espacoAmostral));

                // Probabilidade de obter três caras
                double probabilidadeTresCaras = 1.0 / espacoAmostral.Length;
                Console.WriteLine("\nb) Probabilidade de obter três caras:");
                Console.WriteLine($"P(CCC) = {probabilidadeTresCaras:P2}");

                // Novo espaço amostral: segundo lançamento é cara
                string[] novoEspacoAmostral = { "CCC", "CCK", "KCC", "KCK" };
                Console.WriteLine("\nc) Novo espaço amostral (quando o segundo lançamento é cara):");
                Console.WriteLine(string.Join(", ", novoEspacoAmostral));

                // Nova probabilidade de obter três caras
                double novaProbabilidadeTresCaras = 1.0 / novoEspacoAmostral.Length;
                Console.WriteLine("\nNova probabilidade de obter três caras:");
                Console.WriteLine($"P(CCC | Segundo lançamento = cara) = {novaProbabilidadeTresCaras:P2}");
            
        }
    }
