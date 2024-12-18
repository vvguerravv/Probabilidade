namespace TrabalhoEstatistica;

public class App
{
    public static void Main(string[] args)
    {
        Ex5 ex5 = new Ex5();
        Ex41 ex41 = new Ex41();
        Ex42 ex42 = new Ex42();
        Ex50 ex50 = new Ex50();
        Ex131 ex131 = new Ex131();
        Ex135 ex135 = new Ex135();
        Ex149 ex149 = new Ex149();
        Ex174 ex174 = new Ex174();
        Ex202 ex202 = new Ex202();
        Ex239 ex239 = new Ex239();
        
        Console.WriteLine("Questão 5:  Com os algarismos 1, 2, 3, · · · , 9, quantos números de quatro algarismos existem, em que pelo menos dois são iguais?");
        ex5.calcula();

        Console.WriteLine("\nQuestão 41: Um grupo consta de 20 pessoas, das quais 5 matemáticos. De quantas formas podemos formar comissões de 10 pessoas de modo que: \n a.) nenhum membro seja matemático?\n b.) todos os matemáticos participem da comissão?\n c.) haja exatamente um matemático na comissão?\n d.) pelo menos um membro da comissão seja matemático?");
        ex41.calcula();

        Console.WriteLine("\nQuestão 42: Em uma fábrica com 10 trabalhadores, será selecionado um grupo de 4 para participar de uma excursão sorteada pela empresa. De quantas maneiras o grupo poderá ser formado, considerando que dois dos 10 trabalhadores são casados e somente participarão se ambos forem selecionados?");
        ex42.calcula();

        Console.WriteLine("\nQuestão 50: Num campeonato de futebol participam 20 times. Quantos são os possíveis resultados para?");
        ex50.calcula();

        Console.WriteLine("\nQuestão 131: O jogo da loto consiste em selecionar-se cinco dezenas do conjunto de cem dezenas de 00 a 99. Qual a probabilidade de se acertar a quina (5 dezenas) ao se marcar 10 dezenas no volante?  ");
        ex131.calcula();

        Console.WriteLine("\nQuestão 135: Considere o experimento de lançamento de três moedas:\na.) Qual o espaço amostral?\nb.) Qual a probabilidade de se obter três caras?\nc.) Se soubermos que o segundo lançamento deu\ncara, mas não soubermos os outros, determine o novo espaço amostral e qual a probabilidade de se obter as três caras?");
        ex135.calcular();

        Console.WriteLine("\nQuestão 149: Numa cidade 40% da população é do sexo masculino e 60% é do sexo feminino. Sabe-se que 50% da população masculina e 30% da população feminina já teve dengue. Se uma pessoa for escolhida aleatoriamente nesta cidade, qual a probabilidade de já ter tido a doença?");
        ex149.calcular();
        
        Console.WriteLine("\nQuestão 174: Uma caixa contém bolas, indistinguíveis ao tato, numeradas de 1 a 20. As bolas numeradas de 1 a 10 têm cor verde, e as numeradas de 11 a 20 têm cor amarela. Considere o experimento que consiste em retirar sucessivamente, duas bolas da caixa, não repondo a primeira bola retirada, e em seguida registar a cor das bolas retiradas. a.) Determine a probabilidade das duas bolas retiradas da caixa terem cores diferentes. b.) No mesmo experimento considere os acontecimentos: A: A primeira bola é verde. B: A segunda bola retirada é amarela. C: O número da segunda bola é par. Calcule P((B \u2229 C)|A)\n");
        ex174.calcular();
        
        Console.WriteLine("\nQuestão 202: A máquinas A e B produzem o mesmo tipo de parafuso. A porcentagem de parafusos defeituosos produzido, respectivamente, pela máquina A e B é de 15% e de 5%. foram misturados numa caixa 100 parafusos produzidos por A e 100 parafusos produzidos por B. Se tirarmos um parafuso ao acaso e ele for defeituoso, a probabilidade de que tenha sido produzido pela maquina A é de quanto?");
        ex202.calcula();
        
        Console.WriteLine("\nQuestão 239: Uma empresa costuma treinar seus operadores para realizarem certas tarefas na linha de produção. Sabe-se que os operadores que realizam o curso alcançam suas cotas de produção em 90% do tempo. Os operadores novos, que ainda não realizaram o curso, alcançam suas cotas em apenas 65% do tempo. Cinquenta por cento dos\nnovos operadores passam pelo curso. Dado que um operador alcança sua cota de produção, qual é a probabilidade de que ele tenha passado pelo curso?");
        ex239.calcula();
        
    }
    
}