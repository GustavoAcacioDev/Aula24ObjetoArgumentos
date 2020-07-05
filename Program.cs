using System;

namespace Aula24ObjetoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Air Jordan X", 899.90f);
            Produto p2 = new Produto(2, "Yeezy Boost 350", 3000.00f);
            Produto p3 = new Produto(3, "Air Force", 499.90f);
            Produto p4 = new Produto(4, "Adidas Ultraboost", 699.90f);

            Produto p5 = new Produto(5, "Nike Shox", 300f);

            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);

            carrinho.AlterarItem(1, p5);

            carrinho.RemoverProduto(p3);

            carrinho.MostrarProdutos();

        }
    }
}
