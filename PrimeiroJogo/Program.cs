// Faça como eu fiz: primeiro jogo com C#

Random aleatorio = new Random();
int numeroSorteado = aleatorio.Next(1, 101);

do
{
    Console.Write("\nDigite um número de 1 a 100: ");
    int numeroEscolhido = int.Parse(Console.ReadLine());

    if (numeroEscolhido == numeroSorteado)
    {
        Console.WriteLine("Você acertou!");
        break;
    } 
    if (numeroEscolhido > numeroSorteado) {
        Console.WriteLine("O número sorteado é menor!");
    }
    else {
        Console.WriteLine("O número sorteado é maior!");
    }
    
} while (true);




