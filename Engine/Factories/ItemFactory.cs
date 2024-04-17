using Engine.Actions;
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
            BuildWeapon(1001, "Leaf Wings", 0, "leafwings.jpg", 0, 3);
            BuildWeapon(1002, "Papaya Sword", 10, "papaya sword.png", 1, 4);
            BuildWeapon(1003, "Seed Shield", 50, "seed shield.png", 1, 10);
            BuildWeapon(1004, "SeedLings", 150, "seedlings.jpg", 1, 25);
            BuildWeapon(1005, "Elixir Of Papaya", 0, "elixir of papaya.png", 5, 20);
            BuildWeapon(1006, "CrossBow", 100, "crossbow.jpg", 4, 10);
            BuildWeapon(1007, "Papaya Bag", 0, "papayag bag.jpg", 10, 30);
            BuildWeapon(1008, "Papaya Food", 200, "papayafood.jpg", 1, 15);
            BuildWeapon(1009, "Papaya wing", 200, "papaya wing.jpg", 3, 13);
            BuildWeapon(1010, "Papaya Seeds", 200, "papaya seeds.jpg", 6, 10);

            BuildWeapon(1501, "Weak Magical Stick", 0, "villainitem", 0, 2);
            BuildWeapon(1502, "Dark Club", 0, "villainitem", 0, 3);
            BuildWeapon(1503, "Fire Breath", 0, "villainitem", 1, 5);
            BuildWeapon(1504, "Water Blast", 0, "villainitem", 4, 12);
            BuildWeapon(1505, "Wrath of the Fire Dragon", 0, "villainitem", 5, 15);
            BuildWeapon(1506, "Haunt", 0, "villainitem", 1, 6);
            BuildWeapon(1507, "Ancient Guardian", 0, "villainitem", 10, 15);

            BuildHealingItem(2001, "Potion", 5, 5, "pack://application:,,,/Engine;component/Images/Items/potion.png");

            BuildMiscellaneousItem(2501, "Imp Essence", 10, "collectibleonly");
            BuildMiscellaneousItem(2502, "Lava Golem Core", 50, "collectibleonly");
            BuildMiscellaneousItem(2503, "Water Elemental Crystal", 100, "collectibleonly");
            BuildMiscellaneousItem(2504, "Dragon Scale", 300, "collectibleonly");
            BuildMiscellaneousItem(2505, "Ghostly Orb", 50, "collectibleonly");
            BuildMiscellaneousItem(2506, "Guardian Relic", 300, "collectibleonly");

            BuildMiscellaneousItem(3001, "Potion Bottle", 5, "collectibleonly");
            BuildMiscellaneousItem(3002, "Cleansed Essence", 10, "collectibleonly");
            BuildMiscellaneousItem(3003, "Water", 5, "collectibleonly");

            //s_GameItems.Add(new Weapon(1001, "Stick", 0, "pack://application:,,,/Engine;component/Images/Items/stick.png", 1, 10));
            //s_GameItems.Add(new GameItem(2001, "Imp Essence", 10, "pack://application:,,,/Engine;component/Images/Items/potion.png"));
            //s_GameItems.Add(new GameItem(2002, "Potion", 100, "pack://application:,,,/Engine;component/Images/Items/potion.png"));
            //s_GameItems.Add(new GameItem(9001, "placeholder", 10000, "pack://application:,,,/Engine;component/Images/Items/stick.png"));
        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID)?.Clone();
        }
        private static void BuildMiscellaneousItem(int id, string name, int price, string imageName)
        {
            _standardGameItems.Add(new GameItem(GameItem.ItemCategory.Miscellaneous, id, name, price, imageName));
        }
        private static void BuildWeapon(int id, string name, int price, string imageName,
                                        int minimumDamage, int maximumDamage)
        {
            GameItem weapon = new GameItem(GameItem.ItemCategory.Weapon, id, name, price, imageName, true);
            weapon.Action = new AttackWithWeapon(weapon, minimumDamage, maximumDamage);
            _standardGameItems.Add(weapon);
        }
        private static void BuildHealingItem(int id, string name, int price, int hitPointsToHeal, string imageName)
        {
            GameItem item = new GameItem(GameItem.ItemCategory.Consumable, id, name, price, imageName);
            item.Action = new Heal(item, hitPointsToHeal);
            _standardGameItems.Add(item);
        }
        public static string ItemName(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(i => i.ItemTypeID == itemTypeID)?.Name ?? "";
        }

    }
}
