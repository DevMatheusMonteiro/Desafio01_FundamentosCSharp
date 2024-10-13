namespace Desafio01_FundamentosC_ {
    internal class Program {
        static void Main(string[] args) {
            string? nome = EntrarNome("Entre com seu nome: ");
            BoasVindas(nome);
        }
        static string? EntrarNome(string mensagem) {
            Console.Write(mensagem);
            return Console.ReadLine();
        }
        static void BoasVindas(string? nome) {
            if (string.IsNullOrEmpty(nome)) {
                Console.WriteLine("Erro: nome inválido!");
                return;
            }
            Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo(a)");
        }
    }
}
