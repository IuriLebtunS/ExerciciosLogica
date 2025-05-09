namespace Exercicios
{
    public class Exercicio05_InverterString
    {
        public static void Executar()
        {
            Console.Write("Digite uma string: ");
            string original = Console.ReadLine() ?? "";

            string invertida = Inverter(original);

            Console.WriteLine($"String invertida: {invertida}");
        }

        private static string Inverter(string texto)
        {
            char[] caracteres = new char[texto.Length];
            int j = 0;

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                caracteres[j] = texto[i];
                j++;
            }

            return new string(caracteres);
        }
    }
}
