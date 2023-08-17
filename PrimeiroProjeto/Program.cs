// Screen Sound
string mensagemTeste = "Bom vind@!";
//List<string> listaBandas = new List<string>{"a","b","c"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("teste1", new List<int>{1,3,2});
bandasRegistradas.Add("teste2", new List<int>());

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
    ExibeMensagemInicial();
    
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
        case 3: AvaliarBanda();
            break;
        case 4: ExibirNotaMedia();
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
    ExibirTitiloOpcao("Registro de Bandas");
    Console.Write("Nome: ");
    string nomeBanda = Console.ReadLine()!;
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada");
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void ListarBandas()
{
    Console.Clear();
    ExibirTitiloOpcao("Lista de Bandas registradas");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda {banda}");
    }
    
    Console.WriteLine("\nDigite qualquer tecla para retornar.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirTitiloOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '+');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTitiloOpcao("Avaliar Bandas");
    Console.Write("digite o nome da banda a ser avaliada: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"qual a nota que a {nomeBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine("nota registrada com sucesso!");
        Thread.Sleep(1500);
    } else
    {
      Console.WriteLine($"a banda {nomeBanda} não foi encontrada");  
      Console.WriteLine("Digite qualquer tecla para retornar.");
      Console.ReadKey();
    }
    
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirNotaMedia()
{
    Console.Clear();
    ExibirTitiloOpcao("Nota Média");
    Console.Write("digite o nome da banda que quer ver a média: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        double mediaNota = bandasRegistradas[nomeBanda].Average();
        Console.WriteLine($"Nota média da banda {nomeBanda}: {mediaNota}");

    } else
    {
        Console.WriteLine($"a banda {nomeBanda} não foi encontrada");
    }
    
    Console.WriteLine("Digite qualquer tecla para retornar.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

ExibirOpcoesMenu();

