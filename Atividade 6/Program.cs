string[] nomes = new string[10];

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"{i + 1}) Digite o nome:");
    nomes[i] = Console.ReadLine();
}

Console.WriteLine($"Digite o nome que dejesa pesquisar:");
string pesquisa = Console.ReadLine();

if (nomes.Contains(pesquisa))
{
    Console.WriteLine($"ACHEI!");
}
else
{
    Console.WriteLine($"Nao achei..");
    
}