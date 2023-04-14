using System.Globalization;


//sistema de escolhas 
bool escolhaCerta = false;
string combustivel = "";
float preco = 0;
float DescontoMenor = 0.0f;
float DescontoMaior = 0.0f;

while (escolhaCerta == false)
{
    //primeiro alcool ou gasolina
    Console.WriteLine(@$"
    -------------------------------------------------------------------
    | Seja bem vindo ao nosso posto. hoje vai ser alcool ou gasolina? |
    | digite 'a' para alcool     ou      digite 'g' para gasolina     |
    -------------------------------------------------------------------
    ");
    combustivel = Console.ReadLine();

    switch (combustivel)
    {
        case "a":
            combustivel = "Alcool";
            preco = 4.90f;
            DescontoMenor = 0.03f;
            DescontoMaior = 0.05f;
            escolhaCerta = true;
            break;

        case "g":
            combustivel = "Gasolina";
            preco = 5.30f;
            DescontoMenor = 0.04f;
            DescontoMaior = 0.06f;
            escolhaCerta = true;
            break;

        default:
            Console.WriteLine($"Por favor, repita o processo e me diga o que vai querer");
            escolhaCerta = false;
            break;
    }
}

Console.WriteLine($"Quantos litros?");
int litro = int.Parse(Console.ReadLine());

//metodo de calculo

static float CalcularPreco(float preco, float DescontoMaior, float DescontoMenor, int litro)
{
    if (litro <= 20)
    {
        return (preco - (preco * DescontoMenor)) * litro;
    }
    else if (litro > 20)
    {
        return (preco - (preco * DescontoMaior)) * litro;
    }
    else
    {
        return (preco - (preco * DescontoMenor)) * litro;
    }
}

Console.WriteLine($"Entrao foi {combustivel} hoje, saiu esse preco aqui parceiro(a):");
Console.WriteLine(Math.Round(CalcularPreco(preco, DescontoMaior, DescontoMenor, litro),2).ToString("C", new CultureInfo("pt-BR")));
