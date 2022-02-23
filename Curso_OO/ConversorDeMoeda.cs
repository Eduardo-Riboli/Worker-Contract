namespace Curso_OO
{
    internal class ConversorDeMoeda
    {
        public static double Conversor(double moeda, double valor)
        {
            return (moeda * valor) + (valor * 0.06);
        }
    }
}
