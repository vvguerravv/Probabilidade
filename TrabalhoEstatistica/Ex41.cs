namespace TrabalhoEstatistica;

public class Ex41
{
    public Ex41(){}
    
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

        // Número total de pessoas não matemáticas
        int NaoMatematicos = 15;
        // Número de pessoas a serem escolhidas
        int Escolhidas = 10;

        // Calcula o número de combinações
        long totalFormas = Combinacao(NaoMatematicos, Escolhidas);

        Console.WriteLine($"(a) Total de formas de formar a comissão é: {totalFormas}");
        
        // Número total de formas para a letra (b)
        int matematicos = 5;
        int naoMatematicos = 15;
        int restante = 10 - matematicos; // Precisamos de 5 não matemáticos
        long totalParteB = Combinacao(naoMatematicos, restante);

        Console.WriteLine($"(b) Total de formas para todos os matemáticos participarem: {totalParteB}");
        
        // Número total de formas para a letra (c)
        int matematicosEscolhidos = 1;
        int naoMatematicosEscolhidos = 9;
        long totalParteC = Combinacao(5, matematicosEscolhidos) * Combinacao(15, naoMatematicosEscolhidos);

        Console.WriteLine($"(c) Total de formas para exatamente um matemático participar: {totalParteC}");
        
        // Número total de formas para a letra (d)
        long totalComissoes = Combinacao(20, 10);
        long semMatematicos = Combinacao(15, 10);
        long totalParteD = totalComissoes - semMatematicos;

        Console.WriteLine($"(d) Total de formas para pelo menos um matemático participar: {totalParteD}\n");
    }
}