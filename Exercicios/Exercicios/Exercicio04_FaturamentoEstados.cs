namespace Exercicios
{
    public class Exercicio04_FaturamentoEstados
    {
        public static void Executar()
        {
            var faturamentoPorEstado = new Dictionary<string, double>
            {
                { "SP", 67836.43 },
                { "RJ", 36678.66 },
                { "MG", 29229.88 },
                { "ES", 27165.48 },
                { "Outros", 19849.53 }
            };

            double total = faturamentoPorEstado.Values.Sum();

            Console.WriteLine("Percentual de representação por estado:\n");

            foreach (var estado in faturamentoPorEstado)
            {
                double percentual = (estado.Value / total) * 100;
                Console.WriteLine($"{estado.Key}: {percentual:F2}%");
            }
        }
    }
}
