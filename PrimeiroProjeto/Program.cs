// Screen Sound
string mensagemTeste = "Bom vind@!";
List<string> listaBandas = new List<string>{"a","b","c"};

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
        case 1: RegistrarBandas();
            break;
        case 2: ListarBandas();
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

void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("++++++++++++++++++++++");
    Console.WriteLine("Registro de Bandas");
    Console.WriteLine("++++++++++++++++++++++");
    Console.Write("Nome: ");
    string nomeBanda = Console.ReadLine()!;
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada");
    listaBandas.Add(nomeBanda);
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void ListarBandas()
{
    Console.Clear();
    Console.WriteLine("++++++++++++++++++++++++++++");
    Console.WriteLine("Lista de Bandas registradas");
    Console.WriteLine("++++++++++++++++++++++++++++\n");

    /*for (int i = 0; i < listaBandas.Count; i++)
    {
        Console.WriteLine($"Banda {listaBandas[i]}");
    }*/

    foreach (string banda in listaBandas)
    {
        Console.WriteLine($"Banda {banda}");
    }
    
    Console.WriteLine("\nDigite qualquer tecla para retornar.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

ExibeMensagemInicial();
ExibirOpcoesMenu();

