//data do sitema
DateTime ano = DateTime.Today;

//data de nascimento do usuario
Console.WriteLine($"Por favor, informe seu ano de nascimo para informar se pode votar ou nao");
int anoUsuario = int.Parse(Console.ReadLine());

int idade = ano.Year - anoUsuario;
Console.WriteLine($"{idade} anos de idade");

if (idade == 16)
{
    Console.WriteLine($"O seu voto e opicional");
}
else if (idade >= 18)
{
    Console.WriteLine($"Seu voto e obrigatorio");
}