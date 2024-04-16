using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster caveTrolls =
                        new Monster("Cave Troll", "cavetroll.png", 15, 15, 10, 10);
                    caveTrolls.CurrentWeapon = ItemFactory.CreateGameItem(1502);
                    return caveTrolls;
                case 2:
                    Monster lavaGolem =
                        new Monster("Lava Golem", "lavagolem.png", 40, 40, 20, 30);
                    lavaGolem.CurrentWeapon = ItemFactory.CreateGameItem(1503);
                    AddLootItem(lavaGolem, 2502, 100);
                    return lavaGolem;

                case 3:
                    Monster forestImp =
                        new Monster("Forest Imp", "forestimp.png", 10, 10, 5, 5);
                    forestImp.CurrentWeapon = ItemFactory.CreateGameItem(1501);
                    AddLootItem(forestImp, 2501, 100);
                    return forestImp;

                case 4:
                    Monster waterDragon =
                        new Monster("Water Elemental Dragon", "waterdragon.png", 70, 70, 50, 100);
                    waterDragon.CurrentWeapon = ItemFactory.CreateGameItem(1504);
                    AddLootItem(waterDragon, 2503, 100);
                    return waterDragon;

                case 5:
                    Monster fireDragon =
                        new Monster("Fire Elemental Dragon", "firedragon.png", 120, 120, 100, 500);
                    fireDragon.CurrentWeapon = ItemFactory.CreateGameItem(1505);
                    AddLootItem(fireDragon, 2504, 100);
                    return fireDragon;

                case 6:
                    Monster ghost =
                        new Monster("Ghost", "ghost.png", 20, 20, 15, 20);
                    ghost.CurrentWeapon = ItemFactory.CreateGameItem(1506);
                    AddLootItem(ghost, 2505, 100);
                    return ghost;

                case 7:
                    Monster ancientGuardian =
                        new Monster("Ancient Guardian", "ancientguardian.png", 150, 150, 10, 5);
                    ancientGuardian.CurrentWeapon = ItemFactory.CreateGameItem(1507);
                    AddLootItem(ancientGuardian, 2506, 100);
                    return ancientGuardian;


                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }
        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(ItemFactory.CreateGameItem(itemID));
            }
        }
    }
}
