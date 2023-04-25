string mensagem = "";

try
{
    string produtoselecionado;

    List<string> listamercado = new List<string>()
    {
        "Tomate",
        "Cebola",
        "Coca-cola",
        "Batata",
        "Vinho",
        "Pilha",
        "Suco de uva",
        "Água",
        "Chocolate",
        "Mel"
    };

    Console.WriteLine("Digite um produto que gostaria de comprar:");

    produtoselecionado = Console.ReadLine();

    bool validaproduto = listamercado.Where(l => l.Equals(produtoselecionado)).Any();

    if (validaproduto)
    {
        Console.WriteLine("Você pode comprar o produto " + produtoselecionado + " pois ele está disponível.");
    }
    else
    {
        Console.WriteLine("O produto " + produtoselecionado + " não está a venda.")
    }

    Console.WriteLine("Os produtos disponíveis são:");
    foreach(string produto in listamercado.OrderBy(lista => lista))
    {
        Console.WriteLine(produto);
    }

    mensagem = "Obrigado por ter utilizado o sistema do mercado. E boas compras!";

} catch (Exception ex)
{
    mensagem = "Aconteceu o seguinte problema: " + ex.Message;
}
finally
{
    Console.WriteLine(mensagem);
}