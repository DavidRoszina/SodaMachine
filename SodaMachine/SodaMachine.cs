using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics;

namespace SodaMachine
{
    class SodaMachine
    {
        //member variables
        public int enteredAmount;
        private int sumOfChange;
        public Inventory inventory;
        public CashBox cashbox;
        
        //constructor
        public SodaMachine()
        {
            inventory = new Inventory();
            inventory.AddGrapeToInventory(20);
            inventory.AddOrangeToInventory(20);
            inventory.AddLemonToInventory(20);
            cashbox = new CashBox();
            cashbox.AddQuarterToCashBox(20);
            cashbox.AddDimeToCashBox(10);
            cashbox.AddNickelToCashBox(20);
            cashbox.AddPennyToCashBox(50);
            enteredAmount = 0;
            

        }
        //methods

        public bool EnterCoins()
        {
            Console.WriteLine("Enter a quarter, dime, nickel, penny or done:\n");
            string enteredCoin = Console.ReadLine();
            if (enteredCoin == "quarter")
            {
                cashbox.AddQuarterToCashBox(1);
                enteredAmount = (enteredAmount + Quarter.WORTH);
                Console.WriteLine("You have entered " + enteredAmount);

            }
            else if (enteredCoin == "dime")
            {
                cashbox.AddDimeToCashBox(1);
                enteredAmount = (enteredAmount + Dime.WORTH);
                Console.WriteLine("You have entered " + enteredAmount);

            }
            else if (enteredCoin == "nickel")
            {
                cashbox.AddNickelToCashBox(1);
                enteredAmount = (enteredAmount + Nickel.WORTH);
                Console.WriteLine("You have entered " + enteredAmount);

            }
            else if (enteredCoin == "penny")
            {
                cashbox.AddPennyToCashBox(1);
                enteredAmount = (enteredAmount + Penny.WORTH);
                Console.WriteLine("You have entered " + enteredAmount);

            }
            else if (enteredCoin == "done")
            {
                Console.WriteLine("You have entered " + enteredAmount);
                return false;
            }
            return true;
        }
        public bool DispenseSoda()
        {
            Console.WriteLine("Please select grape, orange, or lemon\n");
            string enteredFlavor = Console.ReadLine();
            if (enteredFlavor == "grape")
            {
                if (enteredAmount < GrapeSoda.PRICE)
                {

                    Console.WriteLine("Insufficient funds. Would you like to make another selection? y/n\n");
                    if (Console.ReadLine() == "n")
                    {
                        return false;
                    }
                }
                else if (inventory.grapes.Count == 0)
                {

                    Console.WriteLine("Grape Soda out of stock. Would you like to make another selection> y/n\n");
                    if (Console.ReadLine() == "n")
                    {

                        return false;
                    }
                }
                else
                {
                    if (CanMakeChange(GrapeSoda.PRICE) == true)
                    { 
                        inventory.grapes.RemoveAt(0);
                        enteredAmount = (enteredAmount - GrapeSoda.PRICE);
                        Console.WriteLine("Grape Soda Dispensed");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient change in machine");
                        
                    }
                    ReturnChange(cashbox, true);

                    Console.WriteLine("Would you like to make another transaction> y/n\n");
                    if (Console.ReadLine() == "n")
                    {
                        return false;
                    }
                }
            }
            else if (enteredFlavor == "orange")
            {
                if (enteredAmount < OrangeSoda.PRICE)
                {
                    
                    Console.WriteLine("Insufficient funds. Would you like to make another selection? y/n\n");
                    if (Console.ReadLine() == "n")
                    {
                        return false;
                    }
                }
                else if (inventory.oranges.Count == 0)
                {
                    
                    Console.WriteLine("Orange Soda out of stock. Would you like to make another selection> y/n\n");
                    if (Console.ReadLine() == "n")
                    {
                        return false;
                    }
                }
                else
                {
                    if (CanMakeChange(OrangeSoda.PRICE) == true)
                    {
                        inventory.oranges.RemoveAt(0);
                        enteredAmount = (enteredAmount - OrangeSoda.PRICE);
                        Console.WriteLine("Orange Soda Dispensed");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient change in machine");

                    }
                    ReturnChange(cashbox, true);
                    Console.WriteLine("Would you like to make another transaction> y/n\n");
                    if (Console.ReadLine() == "n")
                    {
                        return false;
                    }
                }
            }
            else if (enteredFlavor == "lemon")
            {
                if (enteredAmount < LemonSoda.PRICE)
                {
                    
                    Console.WriteLine("Insufficient funds. Would you like to make another selection? y/n\n");
                    if (Console.ReadLine() == "n")
                    {
                        return false;
                    }
                }
                else if (inventory.lemons.Count == 0)
                {
                    
                    Console.WriteLine("Lemon Soda out of stock. Would you like to make another selection> y/n\n");
                    if (Console.ReadLine() == "n")
                    {
                        return false;
                    }
                }
                else
                {
                    if (CanMakeChange(LemonSoda.PRICE) == true)
                    {
                        inventory.lemons.RemoveAt(0);
                        enteredAmount = (enteredAmount - LemonSoda.PRICE);
                        Console.WriteLine("Lemon Soda Dispensed");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient change in machine");

                    }
                    ReturnChange(cashbox, true);
                    Console.WriteLine("Would you like to make another transaction> y/n\n");
                    if (Console.ReadLine() == "n")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool CanMakeChange(int cost)
        {
            int priorAmount = enteredAmount;
            enteredAmount -= cost;
            CashBox tempCashBox = new CashBox(cashbox);
            bool result = ReturnChange(tempCashBox, false);
            enteredAmount = priorAmount;
            return result;
        }
        public bool ReturnChange(CashBox box, bool printText)
        {
            while (enteredAmount > 0)
            {
                if (enteredAmount >= 25 && cashbox.quarters.Count > 0)
                {

                    if (printText) Console.WriteLine("The Machine dispensed one quarter.");
                    cashbox.RemoveQuarterFromCashBox(1);
                    enteredAmount = (enteredAmount - Quarter.WORTH);

                }
                else if (enteredAmount >= 10 && cashbox.dimes.Count > 0)
                {

                    if (printText) Console.WriteLine("The Machine dispensed one dime.");
                    cashbox.RemoveDimeFromCashBox(1);
                    enteredAmount = (enteredAmount - Dime.WORTH);

                }
                else if (enteredAmount >= 5 && cashbox.nickels.Count > 0)
                {

                    if (printText) Console.WriteLine("The Machine dispensed one nickel.");
                    cashbox.RemoveNickelFromCashBox(1);
                    enteredAmount = (enteredAmount - Nickel.WORTH);

                }
                else if (enteredAmount >= 1 && cashbox.pennies.Count > 0)
                {

                    if (printText) Console.WriteLine("The Machine dispensed one penny.");
                    cashbox.RemovePennyFromCashBox(1);
                    enteredAmount = (enteredAmount - Penny.WORTH);

                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
