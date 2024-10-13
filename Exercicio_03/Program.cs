namespace Exercicio_03 {
    internal class Program {
        static void Main(string[] args) {
            double valor1 = EntrarNumero("Entre com o valor 1: ");
            double valor2 = EntrarNumero("Entre com o valor 2: ");
            Exibir(valor1, valor2);
        }
        static double EntrarNumero(string mensagem) {
            do {
                try {
                    Console.Write(mensagem);
                    return double.Parse(Console.ReadLine());
                } catch(FormatException) {
                    Console.WriteLine("Erro: formato inválido!");
                }
            }
            while (true);
        }
        static double Soma(double valor1, double valor2) => valor1 + valor2;
        static double Subtracao(double valor1, double valor2) => valor1 - valor2;
        static double Multiplicacao(double valor1, double valor2) => valor1 * valor2;
        static double Divisao(double valor1, double valor2) => valor1 / valor2;
        static double Media(double valor1, double valor2) => (valor1 + valor2) / 2;
        static void Exibir(double valor1, double valor2) {
            Console.WriteLine("Soma: " + Soma(valor1, valor2));
            Console.WriteLine("Subtração: " + Subtracao(valor1, valor2));
            Console.WriteLine("Multiplicação: " + Multiplicacao(valor1, valor2));
            Console.WriteLine("Divisão: " + Divisao(valor1, valor2));
            Console.WriteLine("Média: " + Media(valor1, valor2));
        }
    }
}
