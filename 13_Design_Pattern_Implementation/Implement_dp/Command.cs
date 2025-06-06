using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace command_dp
{
    public interface ICommand
    {
        public void Execute();
    }
    public class Television
    {
        public void Menyala()
        {
            Console.WriteLine("Televisi Menyala");
        }
        public void Mati()
        {
            Console.WriteLine("Televisi Mati");
        }
    }
    public class TelevisonMenyala : ICommand
    {
        private readonly Television? _television;
        public TelevisonMenyala(Television? television)
        {
            _television = television;
        }
        public void Execute()
        {
            _television!.Menyala();
        }
    }
    public class TelevisonMati : ICommand
    {
        private readonly Television? _television;
        public TelevisonMati(Television? television)
        {
            _television = television;
        }
        public void Execute()
        {
            _television!.Mati();
        }
    }
    public class RemoteTv
    {
        private ICommand? Menyala;
        private ICommand? Mati;

        public void setMenyala(ICommand? command)
        {
            Menyala = command;
        }
        public void setMati(ICommand? command)
        {
            Mati = command;
        }
        public void MenyalaTv()
        {
            Menyala!.Execute();
        }
        public void MatiTv()
        {
            Mati!.Execute();
        }
    }
}
