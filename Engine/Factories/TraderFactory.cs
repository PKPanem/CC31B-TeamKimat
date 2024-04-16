using System;
using System.Collections.Generic;
using System.Linq;
using Engine.Models;

namespace Engine.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();
        static TraderFactory()
        {
            Trader carandang = new Trader("Carandang");
            carandang.AddItemToInventory(ItemFactory.CreateGameItem(72));
            Trader farmerKurt = new Trader("Farmer Kurt");
            farmerKurt.AddItemToInventory(ItemFactory.CreateGameItem(72));
            Trader batasTheLaw = new Trader("Batas The Law");
            batasTheLaw.AddItemToInventory(ItemFactory.CreateGameItem(72));
            AddTraderToList(carandang);
            AddTraderToList(farmerKurt);
            AddTraderToList(batastheLaw);
        }
        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }
        private static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a trader named '{trader.Name}'");
            }
            _traders.Add(trader);
        }
    }
}
