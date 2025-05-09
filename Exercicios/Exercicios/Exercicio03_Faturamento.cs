namespace Exercicios
{
    public class Exercicio03_Faturamento
    {
        public static void Executar()
        {
            string caminhoArquivo = "Data/faturamento.json";  

            var faturamentos = FaturamentoService.CarregarFaturamentosDoArquivo(caminhoArquivo);

            var maiorFaturamento = FaturamentoService.CalcularMaiorFaturamento(faturamentos);
            Console.WriteLine($"Maior Faturamento: R${maiorFaturamento}");

            var menorFaturamento = FaturamentoService.CalcularMenorFaturamento(faturamentos);
            Console.WriteLine($"Menor Faturamento: R${menorFaturamento}");

            var mediaFaturamento = FaturamentoService.CalcularMediaFaturamento(faturamentos);
            Console.WriteLine($"Média de Faturamento: R${mediaFaturamento}");
        }
    }
}