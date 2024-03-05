Console.WriteLine("Bem vindo ao meu programa de cálculo da média de ações!");

Console.WriteLine("Digite o valor de até 10 ações para calcular o valor médio,");
Console.WriteLine("Ou digite 'fim' para encerrar e realizar o cálculo.");

bool continuar = true;

while (continuar)
{
    double soma = 0;
    int contador = 0;

    //loop para ler os valores digitados
    while (contador < 10)
    {
        Console.Write($"Ação {contador + 1}: ");
        string input = Console.ReadLine();

        //aqui verifica se o usuário deseja parar
        if (input.ToLower() == "fim")
            break;

        //verificar se o caractere digitado é de fato um número ou valor
        if (double.TryParse(input, out double numero))
        {
            soma += numero;
            contador++;
        }
        else
        {
            Console.WriteLine("Por favor, insira um valor válido.");
        }
    }

    //verifica se pelo menos um número foi inserido
    if (contador > 0)
    {
        double media = soma / contador;
        Console.WriteLine($"A média das ações inseridas é: {media}");
    }
    else
    {
        Console.WriteLine("Nenhuma ação foi inserida.");
    }
    Console.WriteLine("Deseja calcular a média de novas ações?");
    string resposta = Console.ReadLine().ToUpper();

    continuar = resposta == "S" ? true : false;
}

Console.WriteLine("Obrigado por utilizar o meu programa de cálculo de média de ações. Pressione enter para sair.");
Console.ReadLine();