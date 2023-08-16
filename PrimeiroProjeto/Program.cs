// Screen Sound
string mensagemTeste = "Bom vind@!";

void ExibeMensagemInicial()
{
    Console.WriteLine(@"
    
     ███████████████████████████████████████████████
     █▄─▄▄─█▄─▄████▀▄─██▄─█─▄█▄─▄███▄─▄█─▄▄▄▄█─▄─▄─█ 
     ██─▄▄▄██─██▀██─▀─███▄─▄███─██▀██─██▄▄▄▄─███─███
     █▄▄▄███▄▄▄▄▄█▄▄█▄▄██▄▄▄██▄▄▄▄▄█▄▄▄█▄▄▄▄▄██▄▄▄██
    ");
    Console.WriteLine(mensagemTeste + "\n");
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("1 - registrar banda");
    Console.WriteLine("2 - Listar banda");
    Console.WriteLine("3 - Avaliar banda");
    Console.WriteLine("4 - Exibir média");
    Console.WriteLine("0 - Sair");
    
    Console.Write("\nDigite a opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEsoclhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEsoclhidaNumerica)
    {
        case 1: Console.WriteLine("Digitou " + opcaoEsoclhidaNumerica);
            break;
        case 2: Console.WriteLine("Digitou " + opcaoEsoclhidaNumerica);
            break;
        case 3: Console.WriteLine("Digitou " + opcaoEsoclhidaNumerica);
            break;
        case 4: Console.WriteLine("Digitou " + opcaoEsoclhidaNumerica);
            break;
        case 0: Console.WriteLine("Fechando");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }

}

ExibeMensagemInicial();
ExibirOpcoesMenu();