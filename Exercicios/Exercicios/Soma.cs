namespace Exercicios;

public static class Exercicio01_Soma
{
    public static void Executar()
    {
        int INDICE = 13;
        int SOMA = 0;
        int K = 0;

        while (K < INDICE)
        {
            K += 1;
            SOMA += K;
        }

        Console.WriteLine("Exercício 01 - Valor final de SOMA: " + SOMA);
    }
}