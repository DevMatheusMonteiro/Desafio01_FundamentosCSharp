namespace Exercicio_04 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite o texto: ");
            string texto = Console.ReadLine();
            int contador = 0;           
            for (int i = 0; i < texto.Length; i++) {
                if (texto[i] == ' ') {
                    continue;
                }
                contador++;
            }
            Console.WriteLine($"Total de caracteres: {contador}");
        }
    }
}
