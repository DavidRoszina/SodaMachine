using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Inventory
    {
        //member variables
        public List<GrapeSoda> grapes;
        public List<OrangeSoda> oranges;
        public List<LemonSoda> lemons;
        public int index;
        //constructor
        public Inventory()
        {
            grapes = new List<GrapeSoda>();
            oranges = new List<OrangeSoda>();
            lemons = new List<LemonSoda>();
        }
        //methods
        public void AddGrapeToInventory(int numberOfGrape)
        {
            for (int i = 0; i < numberOfGrape; i++)
            {
                GrapeSoda grape = new GrapeSoda();
                grapes.Add(grape);
            }
        }
        public void AddOrangeToInventory(int numberOfOrange)
        {
            for (int i = 0; i < numberOfOrange; i++)
            {
                OrangeSoda orange = new OrangeSoda();
                oranges.Add(orange);
            }
        }
        public void AddLemonToInventory(int numberOfLemon)
        {
            for (int i = 0; i < numberOfLemon; i++)
            {
                LemonSoda lemon = new LemonSoda();
                lemons.Add(lemon);
            }
        }
        public void RemoveGrapeFromInventory()
        {
            if (grapes.Count > 0)
            {
                GrapeSoda grape = new GrapeSoda();
                grapes.Remove(grape);
            }
            else
            {
                Console.WriteLine("No Grape Soda Left.");
            }
        }
        public void RemoveOrangeFromInventory()
        {
            if (oranges.Count > 0)
            {
                OrangeSoda orange = new OrangeSoda();
                oranges.Remove(orange);
            }
            else
            {
                Console.WriteLine("No Orange Soda Left.");
            }
        }
        public void RemoveLemonFromInventory()
        {
            if (lemons.Count > 0)
            {
                LemonSoda lemon = new LemonSoda();
                lemons.Remove(lemon);
            }
            else
            {
                Console.WriteLine("No Grape Soda Left.");
            }
        }
    }
}
