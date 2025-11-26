namespace ClassesEstaticas
{
    public static class CauculosMatematicos
    {
        public static double PI = 3.14159265359;

        public static float Somar(float x, float y)
        {
            return x + y;

        }
        public static float Subitracao(float x, float y)
        {
            return x - y;

        }
        public static float Divisao(float x, float y)
        {
            if (y == 0)
            {
                Console.WriteLine($"Nao pode ser igual a zero ");

            }
            return x / y;

        }
        public static float Multiplicacao(float x, float y)
        {
            return x * y;

        }

        public static void MenorEMaior(float x , float y)
        {
            float menor = Math.Min(x, y);
            float maior = Math.Max(x, y);

            Console.WriteLine($"o maior numero e {maior}");
        }
    }
}