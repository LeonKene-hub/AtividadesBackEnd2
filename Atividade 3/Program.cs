//sistema para criar o produto
Console.WriteLine(@$"
--------------------------------------------------
|          Seja bem vindo ao armazem             |
|     Por favor registre os novos produtos       |
--------------------------------------------------
");


//nome
Console.WriteLine($"Defina o nome do produto");
string nome = Console.ReadLine();

//quantidade recebida
Console.WriteLine($"Defina a quantidade recebida do produto");
int quantidade = int.Parse(Console.ReadLine());

//preco unitario
Console.WriteLine($"Defina o preco unitario do produto");
float preco = float.Parse(Console.ReadLine());

Console.WriteLine($"Os produtos: {nome} no final custam {CalcularTotal(quantidade, preco)}");



//definir desconto a partir da quantidade
static float CalcularTotal(int quantidade, float preco)
{
    float total = 0;
    float desconto = 0;

    //calcular total (total = quantidade recebida * preco unitario)
    total = quantidade * preco;


    //calcular desconto logo em seguida (total - desconto)
    if (quantidade <= 5)
    //se quantidade <= 5 desconto de 2% 
    {
        desconto = total * 0.02f;
        return total = (total - desconto);
    }
    else if (quantidade > 5 && quantidade <= 10)
    //se quantidade > 5 e <= 10 desconto de 3%
    {
        desconto = total * 0.03f;
        return total = (total - desconto);
    }
    else
    //se quantidade > 10 desconto de 5%
    {
        desconto = total * 0.05f;
        return total = (total - desconto);
    }

}
