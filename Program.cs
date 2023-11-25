using bootcamp.Models;

bool encerrado = false;
int escolhaMenu;
Estacionamento est = new Estacionamento();

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial");
string inputPrecoInicial = Console.ReadLine();
if (decimal.TryParse(inputPrecoInicial, out decimal precoInicial))
{
    est.precoInicial = precoInicial;
}
Console.WriteLine("Agora digite o preço por hora");
string inputPrecoPorHora = Console.ReadLine();
if (decimal.TryParse(inputPrecoPorHora, out decimal precoPorHora))
{
    est.precoPorHora = precoPorHora;
}
Console.Clear();

while (encerrado==false)
{
    Console.Clear();
    Console.WriteLine("Digite a sua ação:");
    Console.WriteLine("1- Cadastrar o veículo");
    Console.WriteLine("2- Remover veículo");
    Console.WriteLine("3- Listar veículos");
    Console.WriteLine("4- Encerrar");

    escolhaMenu = Convert.ToInt16(Console.ReadLine());

    switch (escolhaMenu)
    {
        case 1:
            est.CadastrarCarro();
            break;

        case 2:
            est.RemoverCarro();
            break;

        case 3:
            est.ListarCarros();
            break;

        case 4:
            encerrado=true;
            break;

        default:
            Console.WriteLine("Valor inválido para este menu");
            break;
    }
    Console.WriteLine("Precione uma tecla para continuar:");
    Console.ReadLine();
}

