using Microsoft.Win32.SafeHandles;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private decimal Horas = 0;
        private decimal precoTotal = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora, decimal Horas, decimal precoTotal)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.Horas = Horas;
            this.precoTotal = precoTotal;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string RecebePlaca = Console.ReadLine();
            veiculos.Add(RecebePlaca);
            
        }

        public void RemoverVeiculo()
        {
            

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
             Console.WriteLine("Digite a placa do veículo para retirar:");
            string placa = Console.ReadLine();
            
              // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                string ReceberHoras = Console.ReadLine();
                
                Console.WriteLine("Digite o numero de horas estacionado:");
                
                decimal HorasConvertidas = Convert.ToDecimal(ReceberHoras);
                decimal Horas = HorasConvertidas;
                decimal precoTotal = precoInicial + precoPorHora * Horas;

                
                 
                veiculos.Remove(placa);
                
                
                                            



        

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {precoTotal}");
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
                for(int contador = 0; contador < veiculos.Count; contador++)
                {
                    Console.WriteLine($"Posicao Numero {contador}-{veiculos[contador]} ");
                }
               
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
