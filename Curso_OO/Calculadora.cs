namespace Curso_OO
{
    class Calculadora 
    {
        public static double Pi = 3.14;
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }

        // -------------------------------------------------
        // Fazendo soma usando vetor com quantos números o usuário quiser.

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static void Triplo(ref int x)
        {
            x = x * 3;
        }

        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}

