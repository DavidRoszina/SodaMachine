using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class RestStop
    {
        //member variables
        public SodaMachine machine;
        //constructor
        public RestStop()
        {
            SodaMachine machine = new SodaMachine();
        }
        //methods
        public void RunGame()
        {
            Console.WriteLine("Soda List: Grape, Orange, Lemon");
            Console.WriteLine("Grape - $.60, Orange - $.35, Lemon - $.06");
            Console.WriteLine("Please enter your money and then make a selection");
            machine.EnterCoins();
        }
    }
}
