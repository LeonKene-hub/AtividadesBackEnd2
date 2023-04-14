//declarar 15 numeros
int[] numeros = new int[15];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Registre o {i + 1}º numero:");
    numeros[i] = int.Parse(Console.ReadLine());
}

//percorrer na ordem ao contraria
for (int i = 14; i >= 0; i--)
{
    Console.WriteLine($"Invertendo: {numeros[i]}");
        
}