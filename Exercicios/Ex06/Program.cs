
using System.Globalization;

class Program
{

    static void Main()
    {

        List<Produto> produtos = new List<Produto>();

        Console.Write("Quantos produtos você vai cadastrar? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"cadastro de Produtos #{i + 1}");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            produtos.Add(new Produto(nome, preco, quantidade));
        }

        Console.WriteLine("\nProdutos cadastrados:");
        foreach (Produto p in produtos)
        {
            Console.WriteLine(p);
        }

    }


}




public class Produto
{

    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }

    public override string ToString()
    {
        return $"{Nome}, R$ {Preco:F2}, {Quantidade} unidades, Total: R$ {ValorTotalEmEstoque():F2}";
    }
}






