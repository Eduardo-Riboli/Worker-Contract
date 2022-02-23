using System;
using System.Globalization;
namespace Curso_OO
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //CONSTRUTOR
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome; Preco = preco; Quantidade = quantidade;
        }

        //SOBRECARGA DE CONSTRUTOR -> Pode criar quantos quiser, limitando a quantidade
        //De elementos que você vai digitar, como por exemplo, sem a quantidade.
        public Produto(string nome, double preco)
        {
            Nome = nome; Preco = preco; 
        }
        //Construtor Padrão, para não precisar indicar valores na Main.
        public Produto()
        {

        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
