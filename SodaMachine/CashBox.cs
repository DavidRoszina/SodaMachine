using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    public class CashBox
    {
        //member variables
        public List<Quarter> quarters;
        public List<Dime> dimes;
        public List<Nickel> nickels;
        public List<Penny> pennies;
        
        //constructor
        public CashBox()
        {
            quarters = new List<Quarter>();
            dimes = new List<Dime>();
            nickels = new List<Nickel>();
            pennies = new List<Penny>();
        }
        public CashBox(CashBox src)
        {
            quarters = new List<Quarter>();
            dimes = new List<Dime>();
            nickels = new List<Nickel>();
            pennies = new List<Penny>();
            AddQuarterToCashBox(src.quarters.Count);
            AddDimeToCashBox(src.dimes.Count);
            AddNickelToCashBox(src.nickels.Count);
            AddPennyToCashBox(src.pennies.Count);
        }
        //member methods
        public void AddQuarterToCashBox(int numberOfQuarters)
        {
            for (int i = 0; i < numberOfQuarters; i++)
            {
                Quarter quarter = new Quarter();
                quarters.Add(quarter);
            }
        }
        public void AddDimeToCashBox(int numberOfDimes)
        {
            for (int i = 0; i < numberOfDimes; i++)
            {
                Dime dime = new Dime();
                dimes.Add(dime);
            }
        }
        public void AddNickelToCashBox(int numberOfNickels)
        {
            for (int i = 0; i < numberOfNickels; i++)
            {
                Nickel nickel = new Nickel();
                nickels.Add(nickel);
            }
        }
        public void AddPennyToCashBox(int numberOfPennies)
        {
            for (int i = 0; i < numberOfPennies; i++)
            {
                Penny penny = new Penny();
                pennies.Add(penny);
            }
        }
        public void RemoveQuarterFromCashBox(int numberOfQuarters)
        {
            for (int i = 0; i < numberOfQuarters; i++)
            {
                
                quarters.RemoveAt(0);
            }
        }
        
        public void RemoveDimeFromCashBox(int numberOfDimes)
        {
            for (int i = 0; i < numberOfDimes; i++)
            {
             
                dimes.RemoveAt(0);
            }
        }
        public void RemoveNickelFromCashBox(int numberOfNickels)
        {
            for (int i = 0; i < numberOfNickels; i++)
            {
             
                nickels.RemoveAt(0);
            }
        }
        public void RemovePennyFromCashBox(int numberOfPennies)
        {
            for (int i = 0; i < numberOfPennies; i++)
            {
            
                pennies.RemoveAt(0);
            }
        }
    }
}
