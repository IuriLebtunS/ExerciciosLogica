using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Exercicios
{
    public class FaturamentoService
    {
        public static List<FaturamentoDia> CarregarFaturamentosDoArquivo(string caminhoArquivo)
        {
            try
            {
                var json = File.ReadAllText(caminhoArquivo);

                var faturamentos = JsonConvert.DeserializeObject<List<FaturamentoDia>>(json);

                return faturamentos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler ou deserializar o arquivo JSON: {ex.Message}");
                return new List<FaturamentoDia>();  // Retorna uma lista vazia em caso de erro
            }
        }

        public static double CalcularMaiorFaturamento(List<FaturamentoDia> faturamentos)
        {
            double maiorFaturamento = 0.0;
            foreach (var faturamento in faturamentos)
            {
                if (faturamento.Valor > maiorFaturamento)
                {
                    maiorFaturamento = faturamento.Valor;
                }
            }
            return maiorFaturamento;
        }

        public static double CalcularMenorFaturamento(List<FaturamentoDia> faturamentos)
        {
            double menorFaturamento = double.MaxValue;
            foreach (var faturamento in faturamentos)
            {
                if (faturamento.Valor < menorFaturamento && faturamento.Valor > 0)
                {
                    menorFaturamento = faturamento.Valor;
                }
            }
            return menorFaturamento;
        }

        public static double CalcularMediaFaturamento(List<FaturamentoDia> faturamentos)
        {
            double somaFaturamento = 0.0;
            int diasComFaturamento = 0;
            foreach (var faturamento in faturamentos)
            {
                if (faturamento.Valor > 0)
                {
                    somaFaturamento += faturamento.Valor;
                    diasComFaturamento++;
                }
            }
            return diasComFaturamento > 0 ? somaFaturamento / diasComFaturamento : 0.0;
        }
    }
}