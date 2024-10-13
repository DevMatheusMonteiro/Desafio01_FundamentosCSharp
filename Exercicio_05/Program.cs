namespace Exercicio_05 {
    internal class Program {
        static void Main(string[] args) {
            string placa = Console.ReadLine();
            bool valido = true;
            if (string.IsNullOrEmpty(placa) || placa.Length != 7) {
                valido = false;
            } else { 
                string tresPrimeiros = placa.Substring(0, 3);
                string quatroUltimos = placa.Substring(3);
                for (int i = 0; i < tresPrimeiros.Length; i++) {
                    if (!char.IsLetter(tresPrimeiros[i])) {
                        valido = false;
                        break;
                    }
                }
                for (int i = 0; i < quatroUltimos.Length; i++) {
                    if (!char.IsNumber(quatroUltimos[i])) {
                        valido = false;
                        break;
                    }
                }
            }
            Console.WriteLine(valido ? "Placa Válida": "Placa Inválida");
        }
    }
}
