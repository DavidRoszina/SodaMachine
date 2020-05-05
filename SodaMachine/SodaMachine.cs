using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public string enteredFlavor;
        public Inventory inventory;
        public CashBox cashbox;
        private int index;
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
        public void DispenseSoda()
        {
            Console.WriteLine("Please select grape, orange, or lemon\n");
            string enteredFlavor = Console.ReadLine();
            if (enteredFlavor == "grape")
            {
                if (enteredAmount >= .60 && inventory.grapes.Count > 0)
                {
                    Console.WriteLine("Grape Soda Dispensed");
                    inventory.grapes.RemoveAt(0);
                    inventory.grapes[index] = inventory.grapes[index + 1];

                }
                else if (enteredAmount < .60)
                {
                    Console.WriteLine("Insufficient funds. Would you like to make another selection? y/n\n");
                    if (Console.ReadLine() == "y")
                    {
                        DispenseSoda();
                    }
                    else if (Console.ReadLine() == "n")
                    {
                        ReturnChange();
                    }
                }
                else if (inventory.grapes.Count == 0)
                {
                    Console.WriteLine("Grape Soda out of stock. Would you like to make another selection> y/n\n");
                    if (Console.ReadLine() == "y")
                    {
                        DispenseSoda();
                    }
                    else if (Console.ReadLine() == "n")
                    {
                        ReturnChange();
                    }
                }
                else DispenseSoda();
            }
            else if (enteredFlavor == "orange")
            {
                if (enteredAmount >= .60 && inventory.oranges.Count > 0)
                {
                    Console.WriteLine("Orange Soda Dispensed");
                    inventory.oranges.RemoveAt(0);
                    inventory.oranges[index] = inventory.oranges[index + 1];

                }
                else if (enteredAmount < .35)
                {
                    Console.WriteLine("Insufficient funds. Would you like to make another selection? y/n\n");
                    if (Console.ReadLine() == "y")
                    {
                        DispenseSoda();
                    }
                    else if (Console.ReadLine() == "n")
                    {
                        ReturnChange();
                    }
                }
                else if (inventory.oranges.Count == 0)
                {
                    Console.WriteLine("Orange Soda out of stock. Would you like to make another selection> y/n\n");
                    if (Console.ReadLine() == "y")
                    {
                        DispenseSoda();
                    }
                    else if (Console.ReadLine() == "n")
                    {
                        ReturnChange();
                    }
                }
                else DispenseSoda();
            }
            else if (enteredFlavor == "lemon")
            {
                if (enteredAmount >= .60 && inventory.lemons.Count > 0)
                {
                    Console.WriteLine("Lemon Soda Dispensed");
                    inventory.lemons.RemoveAt(0);
                    inventory.lemons[index] = inventory.lemons[index + 1];

                }
                else if (enteredAmount < .06)
                {
                    Console.WriteLine("Insufficient funds. Would you like to make another selection? y/n\n");
                    if (Console.ReadLine() == "y")
                    {
                        DispenseSoda();
                    }
                    else if (Console.ReadLine() == "n")
                    {
                        ReturnChange();
                    }
                }
                else if (inventory.lemons.Count == 0)
                {
                    Console.WriteLine("Lemon Soda out of stock. Would you like to make another selection> y/n\n");
                    if (Console.ReadLine() == "y")
                    {
                        DispenseSoda();
                    }
                    else if (Console.ReadLine() == "n")
                    {
                        ReturnChange();
                    }
                }
                else DispenseSoda();
            }
            else
            {
                DispenseSoda();
            }
        }
        public void ReturnChange()
        {
            if (enteredAmount >= .25)
            {
                while (enteredAmount >= .25)
                {
                    cashbox.RemoveQuarterFromCashBox(1);
                    enteredAmount = -.25;
                }
            }
            else if (enteredAmount >= .1)
            {
                while (enteredAmount >= .1)
                {
                    cashbox.RemoveDimeFromCashBox(1);
                    enteredAmount = -.1;
                }
            }
            else if (enteredAmount >= .05)
            {
                while (enteredAmount >= .05)
                {
                    cashbox.RemoveNickelFromCashBox(1);
                    enteredAmount = -.05;
                }
            }
            else if (enteredAmount >= .01)
            {
                while (enteredAmount >= .01)
                {
                    cashbox.RemovePennyFromCashBox(1);
                    enteredAmount = -.01;
                }
            }
            else
            {
                return;
            }


        }
    }
}
