using System;
using System.Collections.Generic;

namespace Aula24ObjetoArgumento
{
    public class Carrinho
    {
        
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        //Metodo para adicionar um produto ao carrinho
        public void AdicionarProduto(Produto produto){
            carrinho.Add(produto);
        }

        //Metodo para remover um produto do carrinho
        public void RemoverProduto(Produto produto){
            carrinho.Remove(produto);
        }


        public void MostrarProdutos(){
            if(carrinho != null){
                foreach(Produto p in carrinho){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" R$ {p.Preco.ToString("n2")} - {p.Nome} ");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
        }




        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if(carrinho !=null){
                foreach(Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                Console.WriteLine($" Valor total do carrinho R$ {ValorTotal.ToString("n2")}");
            }else{
                Console.WriteLine($" Seu carrinho ainda está vazio ");
            }
            Console.ResetColor();
        }



        public void AlterarItem(int _codigo, Produto _novoProduto){
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }
    }
}