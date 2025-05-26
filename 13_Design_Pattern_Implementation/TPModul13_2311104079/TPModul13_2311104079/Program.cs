using System;
using System.Collections.Generic;

namespace TPModul13_2311104079
{
    public class StockMarket
    {
        private string _symbol;
        private decimal _price;
        private List<IStockObserver> _observers = new List<IStockObserver>();

        public StockMarket(string symbol, decimal price)
        {
            _symbol = symbol;
            _price = price;
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    NotifyObservers();
                }
            }
        }

        public void RegisterObserver(IStockObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnregisterObserver(IStockObserver observer)
        {
            _observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_symbol, _price);
            }
        }
    }

    // Observer Interface
    public interface IStockObserver
    {
        void Update(string symbol, decimal price);
    }

    // Concrete Observer 1: Investor
    public class Investor : IStockObserver
    {
        private string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(string symbol, decimal price)
        {
            Console.WriteLine($"[{_name}] Notifikasi: Harga saham {symbol} berubah menjadi {price:C}");
        }
    }

    // Concrete Observer 2: Trading Bot
    public class TradingBot : IStockObserver
    {
        public void Update(string symbol, decimal price)
        {
            if (price > 150m)
            {
                Console.WriteLine($"[BOT] Warning: Harga {symbol} mencapai {price:C} - Pertimbangkan untuk jual");
            }
            else if (price < 100m)
            {
                Console.WriteLine($"[BOT] Warning: Harga {symbol} mencapai {price:C} - Pertimbangkan untuk beli");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Buat subject (stock market)
            var telkomStock = new StockMarket("TLKM", 120m);

            // Buat observer (investor dan bot)
            var investor1 = new Investor("Budi");
            var investor2 = new Investor("Ani");
            var tradingBot = new TradingBot();

            // Daftarkan observer
            telkomStock.RegisterObserver(investor1);
            telkomStock.RegisterObserver(investor2);
            telkomStock.RegisterObserver(tradingBot);

            // Simulasikan perubahan harga
            Console.WriteLine("=== Perubahan Harga Saham TLKM ===");
            telkomStock.Price = 125m;
            telkomStock.Price = 130m;
            telkomStock.Price = 155m;  // Bot akan memberi warning
            telkomStock.Price = 90m;   // Bot akan memberi warning

            // Unregister salah satu investor
            telkomStock.UnregisterObserver(investor2);

            Console.WriteLine("\n=== Investor Ani berhenti berlangganan ===");
            telkomStock.Price = 95m;
        }
    }
}