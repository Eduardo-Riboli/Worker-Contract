using System.Globalization;

namespace Curso_OO
{
    internal class Trabalhador
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double Salario = SalarioBruto * (porcentagem/100);
            SalarioBruto += Salario;
        }
        public override string ToString()
        {
            return Nome + ", $" + SalarioLiquido().ToString("F2", CI) ;
        }

    }
}
