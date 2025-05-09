using System;

namespace Exercicios;

public class Exercicio02_Fibonacci
{
    public static void Executar()
    {
        int numero;
        bool isNumeroValido = false;

        do
        {
            Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci: ");
            string entrada = Console.ReadLine();

            isNumeroValido = int.TryParse(entrada, out numero);

            if (!isNumeroValido)
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }

        } while (!isNumeroValido);

        if (VerificarFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    public static bool VerificarFibonacci(int n)
    {
        int a = 0, b = 1;

        if (n == 0 || n == 1)
            return true;

        while (b < n)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }

        return b == n;
    }
}
