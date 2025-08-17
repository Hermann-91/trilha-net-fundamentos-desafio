namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // CONCLUIDO!! : Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTADO
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            string placaDoVeiculo = Console.ReadLine().ToUpper();

            veiculos.Add(placaDoVeiculo);
            Console.WriteLine($"O veículo {placaDoVeiculo} foi estacionado com sucesso!");
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTADO*
            string placa = Console.ReadLine().ToUpper();
            Console.WriteLine($"Veículo a ser removido: {placa}");

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // CONCLUIDO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,

                // CONCLUIDO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                

                // *IMPLEMENTADO*
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;


                // CONCLUIDO: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);
                // *IMPLEMENTADO*

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}"); // foi incrementado o F2 para o resultado para forçar o resultado para 4 digitos
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"Placa: {veiculo}");
                }
                // concluido!! : Realizar um laço de repetição, exibindo os veículos estacionados
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
