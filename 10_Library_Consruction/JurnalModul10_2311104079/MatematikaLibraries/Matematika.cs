namespace MatematikaLibraries
{
    public class Matematika
    {
        public static int FPB (int a, int b)
        {
            while (b != 0)
            {
                int tempt = b;
                b = a % b;
                a = tempt;
            }
            return a;
        }
        public static int KPK (int a, int b)
        {
            return (a * b) / FPB(a, b);
        }
        public static string Turunan(int[]koef)
        {
            List<string> hasil = new();
            for (int i = 0; i < koef.Length - 1; i++)
            {
                int pangkat = koef.Length - 1 - i;
                int baruKoef = koef[i] * pangkat;
                if (baruKoef == 0) continue;
                string suku = $"{baruKoef}x";
                if (pangkat - 1 > 1) suku += $"^{pangkat - 1}";
                else if (pangkat - 1 == 1) suku += "";
                hasil.Add(suku);
            }
            return string.Join(" + ", hasil).Replace("+ -", "- ");
        }
        public static string Integral(int[] koef)
        {
            List<string> hasil = new();
            for (int i = 0; i < koef.Length; i++)
            {
                int pangkat = koef.Length - i - 1 + 1 ;
                double baruKoef = (double)koef[i] / pangkat;
                string suku = $"{baruKoef}x";
                if (pangkat > 1) 
                    suku += $"^{pangkat}";
                hasil.Add(suku);
            }
            hasil.Add("C");
            return string.Join("+", hasil).Replace("+ -", "- ");
        }
    }
}
