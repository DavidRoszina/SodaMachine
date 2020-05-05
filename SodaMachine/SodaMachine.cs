using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        //member variables
        public double enteredAmount;
        public double change;
        public string enteredCoin;
        public Inventory inventory;
        public CashBox cashbox;
        //constructor
        public SodaMachine()
        {
            Inventory inventory = new Inventory();
            inventory.AddGrapeToInventory(20);
            inventory.AddOrangeToInventory(20);
            inventory.AddLemonToInventory(20);
            CashBox cashbox = new CashBox();
            cashbox.AddQuarterToCashBox(20);
            cashbox.AddDimeToCashBox(10);
            cashbox.AddNickelToCashBox(20);
            cashbox.AddPennyToCashBox(50);
            enteredAmount = 0.00;
            
        }
        //methods
        public void EnterCoins()
        {
            Console.WriteLine("Enter a quarter, dime, nickel, penny or done:\n");
            string enteredCoin = Console.ReadLine();
            if (enteredCoin == "quarter")
            {
                cashbox.AddQuarterToCashBox(1);
                enteredAmount =  +.25;
            }
            else if (enteredCoin == "dime")
            {
                cashbox.AddDimeToCashBox(1);
                enteredAmount = +.1;
            }
            else if (enteredCoin == "nickel")
            {
                cashbox.AddNickelToCashBox(1);
                enteredAmount = +.05;
            }
            else if (enteredCoin == "penny")
            {
                cashbox.AddPennyToCashBox(1);
                enteredAmount = +.01;
            }
            else if (enteredCoin == "done")
            {
                return;
            }
            else EnterCoins();
        }
    }
}
