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
    }
}
