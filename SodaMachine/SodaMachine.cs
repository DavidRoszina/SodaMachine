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


        }
        //methods
        public void EnterCoins()
        {

        }
    }
}
