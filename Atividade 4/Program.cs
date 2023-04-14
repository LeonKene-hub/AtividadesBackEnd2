//armazenar os numeros
int[] numeros = new int[10];

//registrar os numeros
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Informe o {i + 1}º numero");
    numeros[i] = int.Parse(Console.ReadLine());
}

//descubrir qual o maior 
Console.WriteLine($"O maior valor e {numeros.Max()}");

//descubrir qual o menor
Console.WriteLine($"O menor valor e {numeros.Min()}");