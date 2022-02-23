using System;
using System.Globalization;
namespace Curso_OO
{
    internal class Produto2
    {
        private string _nome; 
        private double _preco; // Usando AUTOPROPERTIES -> public double Preco { get; private set};
        private int _quantidade; // Usando AUTOPROPERTIES -> public double Quantidade { get; private set};

        public Produto2(string nome, double preco, int quantidade)
        {
            _nome = nome; _preco = preco; _quantidade = quantidade;
        }

        public Produto2()
        {

        }

        // PROPRIEDADE MAIS UTILIZADA DO C# -> PROPS -> Utiliza-se no lugar do GetNome() e SetNome();
        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 0) // O value seria o parâmetro que viria no SetNome;
                {
                    _nome = value;
                }
            }
        }

        //PARA PEGAR O VALOR DO PRODUTO; NÃO PODE ALTERAR ELES, SOMENTE POR CLASSES ().
        public string GetNome()
        {
            return _nome;
        }

        // PARA ALTERAR O NOME;
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 0)
            {
                _nome = nome;
            }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome + ", $" + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
