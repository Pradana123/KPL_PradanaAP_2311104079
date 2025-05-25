using System;

namespace AljabarLibraries
{
    public class Aljabar
    {
        // Fungsi mencari akar persamaan kuadrat
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double D = b * b - 4 * a * c;

            if (D < 0)
                throw new Exception("Tidak memiliki akar real.");

            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);

            return new double[] { x1, x2 };
        }

        // Fungsi menghitung hasil kuadrat dari bentuk ax + b
        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double a2 = a * a;
            double ab2 = 2 * a * b;
            double b2 = b * b;

            return new double[] { a2, ab2, b2 };
        }
    }
}
