using System.Globalization;

namespace Exercicio_06 {
    internal class Program {
        static void Main(string[] args) {
            DateTime hoje = DateTime.UtcNow.AddHours(-3);
            CultureInfo culture = new CultureInfo("pt-BR");
            int escolha;
            do {
                Console.Write("Escolha um formato da exibição da data:\n\n" +
                    "1 - Formato Completo\n" +
                    "2 - Formato dd/MM/yyyy\n" +
                    "3 - Apenas a hora no formato 24 horas\n" +
                    "4 - Data com mês por extenso\n" +
                    "0 - Encerrar\n");
                escolha = EntrarNumero();
                switch (escolha) {
                    case 1:
                    Console.WriteLine(hoje.ToString("F", culture));
                    break;
                    case 2:
                    Console.WriteLine(hoje.ToString("dd/MM/yyyy", culture));
                    break;
                    case 3:
                    Console.WriteLine(hoje.ToString("HH:mm:ss", culture));
                    break;
                    case 4:
                    Console.WriteLine(hoje.ToString("dd-MMMM-yyyy", culture));
                    break;
                    case 0:
                    Console.WriteLine("Encerrado!");
                    break;
                    default:
                    Console.WriteLine("Opção inválida!");
                    break;
                }
            }
            while (escolha != 0);
        }
        static int EntrarNumero() {
            do {
                try {
                    return int.Parse(Console.ReadLine());
                } catch {
                    Console.WriteLine("Erro: número inválido");
                }
            } while (true);
        }
    }
}
