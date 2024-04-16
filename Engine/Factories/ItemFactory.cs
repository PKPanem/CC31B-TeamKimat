using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();
        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new GameItem(64, "CrossBow", 1, "crossbow.jpg"));
            _standardGameItems.Add(new GameItem(65, "Elixir Of Papaya", 10,"elixir of papaya.jpg"));
            _standardGameItems.Add(new GameItem(66, "LeafWings", 10, "leafwings.jpg"));
            _standardGameItems.Add(new GameItem(67, "PapayaBag", 10, "papaya bag.jpg"));
            _standardGameItems.Add(new GameItem(68, "Papaya Seeds", 10, "papaya seeds.jpg"));
            _standardGameItems.Add(new GameItem(69, "Papaya Sword", 10, "papaya sword.jpg"));
            _standardGameItems.Add(new GameItem(70, "Papaya Tree", 10, "papaya tree.jpg"));
            _standardGameItems.Add(new GameItem(71, "Papaya Wings", 10, "papaya wing.jpg"));
            _standardGameItems.Add(new Weapon(72, "Seed Shield", 10, "seed shield.jpg", 2, 7));
            _standardGameItems.Add(new Weapon(73, "SeedLings", 10, "seedlings.jpg", 2, 7));

        }
        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
            if (standardItem != null)
            {
                if (standardItem is Weapon)
                {
                    return (standardItem as Weapon).Clone();
                }
                return standardItem.Clone();
            }
            return null;
        }
    }
}
