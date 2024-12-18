namespace TrabalhoEstatistica;

public class Ex174
{
    public Ex174(){}

    public void calcular()
    {

        Random random = new Random();
        // Parte (a): Probabilidade de cores diferentes
        int contaCor = 0;
        for(int i = 0;i < 10000000; i++){
            //0 será verde e 1 será amarela
            int[] cores = {random.Next(0,2),random.Next(0,2)};
            if(cores[0] == 0 && cores[1] == 1 || cores[0] == 1 && cores[1] == 0){
                contaCor++;
            }
        }

        Console.WriteLine("a) Probabilidade de as duas bolas terem cores diferentes: " + (double) contaCor*100/10000000);

        // Parte (b): Probabilidade condicional
        int eventosFavoraveis = 0;
        int eventosTotaisVerde = 0;

        for (int i = 0; i < 1000000; i++)
        {
            
            int[] bolas = new int[20];
            for (int j = 0; j < 10; j++) 
                bolas[j] = 1; 
            for (int j = 10; j < 20; j++) 
                bolas[j] = 2; 
            for (int j = 0; j < bolas.Length; j++)
            {
                int k = random.Next(bolas.Length);
                int temp = bolas[j];
                bolas[j] = bolas[k];
                bolas[k] = temp;
            }

            // Retirando a primeira bola
            int primeiraBola = bolas[0];

            if (primeiraBola == 1) // A primeira bola é verde
            {
                eventosTotaisVerde++;

                // Retirando a segunda bola
                int segundaBola = bolas[1];

                if (segundaBola == 2) // Se a segunda bola for amarela
                {
                    // Verificar se o número da segunda bola é par (bolas 12, 14, 16, 18, 20)
                    int numeroSegundaBola = Array.IndexOf(bolas, segundaBola) + 1; 
                    if (numeroSegundaBola % 2 == 0) 
                    {
                        eventosFavoraveis++;
                    }
                }
            }
        }


        double probabilidade = (double)eventosFavoraveis / eventosTotaisVerde;
        Console.WriteLine($"b) Probabilidade P((B ∩ C) | A): {probabilidade:P2}");

    }


    }