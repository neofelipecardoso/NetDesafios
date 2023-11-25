using System;
using System.Collections.Generic;

namespace bootcamp.Models
{
    class Carro
    {
        public string Placa { get; set; }
    }

    public class Estacionamento
    {
        private List<Carro> carros = new List<Carro>();
        public decimal precoInicial{ get; set; }
        public decimal precoPorHora{ get; set; }

        public void CadastrarCarro()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaDigitada=Convert.ToString(Console.ReadLine());
            Carro novoCarro = new Carro { Placa = placaDigitada };
            carros.Add(novoCarro);
        }

        public void RemoverCarro()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placaDigitada=Convert.ToString(Console.ReadLine());
            Carro carroRemover = carros.Find(carro => carro.Placa == placaDigitada);
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu no estacionamento");
            int horasDesseCarro=Convert.ToInt16(Console.ReadLine());

            decimal precoPagar= (horasDesseCarro*precoPorHora)+precoInicial;
            Console.WriteLine($"O veículo {placaDigitada} foi removido e o preço total foi de: {precoPagar:C}");
            carros.Remove(carroRemover);
        }

        public void ListarCarros()
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (var carro in carros)
            {
                Console.WriteLine(carro.Placa);
            }
        }
    }
}
