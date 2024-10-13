namespace Exercicio_02 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Entre com o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Entre com o seu sobrenome: ");
            string sobrenome = Console.ReadLine();
            string nomeCompleto = nome + " " + sobrenome;
            Console.WriteLine(nomeCompleto);
        }
    }
}
