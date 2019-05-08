using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBasket
{
    class Program
    {
        static void Main(string[] args)
        {
            FruitBasket fb = new FruitBasket();
            Console.WriteLine(fb.AddToBasket("Apple"));
            Console.WriteLine(fb.AddToBasket("Orange"));
            Console.WriteLine(fb.AddToBasket("Apple"));
            Console.WriteLine(fb.TakeFromBasket("Apple"));
            Console.WriteLine(fb.TakeFromBasket("Pineapple"));
            Console.WriteLine(fb.AddToBasket("Apple"));
            Console.WriteLine(fb.DisplayFruitInBasket());
            Console.Read();
        }
    }
    class FruitBasket
    {
        private HashSet<string> basket;

        public FruitBasket()
        {
            basket = new HashSet<string>();
        }

        public bool AddToBasket(string fruit)
        {
            return basket.Add(fruit);
        }

        public bool TakeFromBasket(string fruit)
        {
            return basket.Remove(fruit);
        }

        public string DisplayFruitInBasket()
        {
            return String.Join<string>(",", basket);
        }

    }
}
