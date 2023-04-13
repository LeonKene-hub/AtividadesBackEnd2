//escolha entre alcool e gasolina
Console.WriteLine(@$"
Seja bem vindo, gostaria de encher o tanque com alcool ou gasolina?
Digite A para acool ou G para gasolina
");
string escolha = Console.ReadLine().ToLower();
//a ou g

//quantidade
Console.WriteLine($"Quantos litros?");
double litros = double.Parse(Console.ReadLine());
//--------------------------------------------------

Console.WriteLine($"{PostoDeGasolina(escolha, litros)}");


static double PostoDeGasolina(string escolha, double litros)
{
    //valor e o tipo escolhido
    double valor = 0;

    if (escolha == "a")
    {
        escolha = "alcool";
        valor = 4.90f;
    }
    else if (escolha == "g")
    {
        escolha = "gasolina";
        valor = 5.30f;
    }

    //quantidade e preco final
    if (litros <= 20 && escolha == "alcool")
    {
        valor = Math.Round((litros * valor) * 0.97, 2);
        return (valor);
    }
    else if (litros > 20 && escolha == "alcool")
    {
        valor = Math.Round((litros * valor) * 0.95, 2);
        return (valor);
    }
    else if (litros <= 20 && escolha == "gasolina")
    {
        valor = Math.Round((litros * valor) * 0.96, 2);
        return (valor);
    }
    else if (litros > 20 && escolha == "gasolina")
    {
        valor = Math.Round((litros * valor) * 0.94, 2);
        return (valor);
    }

}

