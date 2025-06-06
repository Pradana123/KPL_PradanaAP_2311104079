using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_dp
{
    public interface IAmericanPlug
    {
        void PlugIn();
    }
    public class IndonesianPlug
    {
        public void Sambungkan()
        {
            Console.WriteLine("Stop Kontak Indonesia Tersambung");
        }
    }
    public class PlugAdapter : IAmericanPlug
    {
        private readonly IndonesianPlug _plug;
        public PlugAdapter(IndonesianPlug indonesianPlug)
        {
            _plug = indonesianPlug;
        }
        public void PlugIn()
        {
            Console.WriteLine("Menggunakan adapter colokan Indoensia ke colokan Amerika");
            _plug.Sambungkan();
        }
    }
}
