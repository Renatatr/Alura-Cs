// Faça como eu fiz: for e foreach

List<int> listaInteiros = new List<int>{2,3,5,56,23,123};

Console.WriteLine("FOR:");
for (int i = 0; i < listaInteiros.Count; i++)
{
    if (listaInteiros[i]%2 == 0)
    {
        Console.WriteLine(listaInteiros[i]);
    }
}
Console.WriteLine("FOREACH:");
foreach (var numero in listaInteiros)
{
    if (numero%2 == 0)
    {
        Console.WriteLine(numero);
    }
}