using adapter_dp;
using command_dp;
using implement_dp;
namespace design_pattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==== Program Command ====");
            RemoteTv remote = new RemoteTv();
            Television tv = new Television();
            TelevisonMenyala menyala = new TelevisonMenyala(tv);
            TelevisonMati mati = new TelevisonMati(tv);

            remote.setMenyala(menyala);
            remote.setMati(mati);

            remote.MenyalaTv();
            remote.MatiTv();
            Console.WriteLine("==== Program Adapter ====");
            IndonesianPlug indonesianPlug = new IndonesianPlug();
            IAmericanPlug adaptor = new PlugAdapter(indonesianPlug);
            adaptor.PlugIn(); 

            Console.WriteLine("==== Singleton ====");
            Rektor rektor1 = Rektor.GetRektor();
            Rektor rektor2 = Rektor.GetRektor();

            if (rektor1 == rektor2)
            {
                Console.WriteLine("Rektor Sama");
            }
            else
            {
                Console.WriteLine("Rektor Berbeda");
            }
            rektor1.Ttd();
            Console.ReadLine();
        }
    }
}