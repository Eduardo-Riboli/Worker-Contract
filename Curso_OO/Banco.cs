using System.Globalization;

namespace Curso_OO
{
    internal class Banco
    {
        public string _nome;
        public int NumConta { get; private set; }

        public double Inicial { get; private set; }

        CultureInfo CI = CultureInfo.InvariantCulture;

        public Banco(string nome, int numeroconta, double inicial)
        {
            _nome = nome; NumConta = numeroconta; Inicial = inicial; 
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }


        public override string ToString()
        {
            return "Conta " + NumConta + ", Titular: " + _nome + ", Saldo: $" + SaldoTotal().ToString("F2", CI);
        }

        public double SaldoTotal()
        {
            return Inicial;
        }

        public void AdicionarDeposito(double quantidade)
        {
            Inicial += quantidade;
        }

        public void AdicionarSaque(double quantidade)
        {
            Inicial -= quantidade + 5;
        }


    }
}
