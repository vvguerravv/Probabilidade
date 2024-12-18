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
                Random random = new Random();
                int contaCaras = 0;

                for(int i = 0;i < 1000000;i++){

                     int[] resultados = { random.Next(0, 2), random.Next(0, 2), random.Next(0, 2) };
                    // 1 irá representar cara e 0 coroa
                    if(resultados[0] == 1 && resultados[1] == 1 && resultados[2] == 1) {
                         contaCaras++;
                    }  
                }

            

                Console.WriteLine("\nb) Probabilidade de obter três caras: " + (double) contaCaras * 100/1000000 + "%");


                // Novo espaço amostral: segundo lançamento é cara
                string[] novoEspacoAmostral = { "CCC", "CCK", "KCC", "KCK" };
                Console.WriteLine("\nc) Novo espaço amostral (quando o segundo lançamento é cara):");
                Console.WriteLine(string.Join(", ", novoEspacoAmostral));

                // Nova probabilidade de obter três caras
                 for(int i = 0;i < 100000000;i++){

                     int[] resultados = { random.Next(0, 2), random.Next(0, 2), random.Next(0, 2) };
                    // 1 irá representar cara e 0 coroa
                    if(resultados[0] == 1 && resultados[2] == 1) {
                         contaCaras++;
                    }  
                }

                Console.WriteLine("\nNova probabilidade de obter três caras: " + (double) contaCaras*100/100000000 + "%");
            
        }
    }
