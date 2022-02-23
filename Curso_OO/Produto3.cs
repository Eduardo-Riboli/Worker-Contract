using System;
using System.Globalization;
namespace Curso_OO
{
    internal class Produto3
    {
        // Primeiro: Algum atributo privativo;
        private string _nome;
        // Segundo: Propriedades auto incrementadas;
        public double Preco { get; private set;  }
        public double Quantidade { get; private set;  }

        // Terceiro: Construtores;
        public Produto3()
        {

        }
        public Produto3(string nome, double preco, int quantidade)
        {
            _nome = nome; Preco = preco; Quantidade = quantidade;
        }

        // Quarto: Propriedades Customizadas;
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 0) // O value seria o parâmetro que viria no SetNome;
                {
                    _nome = value;
                }
            }
        }

        // Quinto: Outros métodos;
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
            return _nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
