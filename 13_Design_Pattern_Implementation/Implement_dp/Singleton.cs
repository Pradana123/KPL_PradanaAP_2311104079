using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implement_dp
{
    public sealed class Rektor
    {
        private static Rektor? _instance;
        private Rektor()
        {
            Console.WriteLine("Rektor baru dipilih");
        }
        public static Rektor GetRektor()
        {
            if (_instance == null)
            {
                _instance = new Rektor();
            }
            return _instance;
        }
        public void Ttd()
        {
            Console.WriteLine("Rektor Menandatangani Sebuah Dokumen!!");
        }
    }
}
