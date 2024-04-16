using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld() 
        {
            World newWorld = new World();

            newWorld.AddLocation(0,0, "Home", "A peaceful village where your journey begins", "home.png", "home2.png");

            newWorld.AddLocation(0, 1, "Enchanted Forest", "Dense woods filled with magical creatures", "enchantedforest.png", "enchantedforest2.png");
            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));
            newWorld.LocationAt(0, 1).AddMonster(3, 100);

            newWorld.AddLocation(1, 1, "Caverns of Shadows", "A dark labyrinthine cave system", "cavernsofshadows.png", "cavernsofshadows2.png");
            newWorld.LocationAt(1, 1).TraderHere = TraderFactory.GetTraderByName("Mysterious Trader");
            newWorld.LocationAt(1, 1).AddMonster(1, 100);

            newWorld.AddLocation(-1, 1, "Volcanic Forge", "Fiery landscape with rivers of lava", "volcanicforge.png", "volcanicforge2.png");
            newWorld.LocationAt(-1, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(2));
            newWorld.LocationAt(-1, 1).AddMonster(2, 100);

            newWorld.AddLocation(0, 2, "City of Ancients", "A once-great city now in ruins", "cityofancients.png", "cityofancients2.png");
            newWorld.LocationAt(0, 2).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(6));
            newWorld.LocationAt(0, 2).AddMonster(7, 100);

            newWorld.AddLocation(1, 2, "Skyward Summit", "A floating island in the sky", "skywardsummit.png", "skywardsummit2.png");
            newWorld.LocationAt(1, 2).TraderHere = TraderFactory.GetTraderByName("Mystical Merchant");

            newWorld.AddLocation(-1, 2, "Dragon's Peak", "A towering mountain where dragons reside", "dragonspeak.png", "dragonspeak2.png");
            newWorld.LocationAt(-1, 2).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(4));
            newWorld.LocationAt(-1, 2).AddMonster(5, 100);

            newWorld.AddLocation(-1, 0, "Haunted Graveyard", "Eerie graveyard with restless spirits", "hauntedgraveyard2.png", "hauntedgraveyard.png");
            newWorld.LocationAt(-1, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(5));
            newWorld.LocationAt(-1, 0).AddMonster(6, 100);

            newWorld.AddLocation(1, 0, "Crystal Lake Shore", "A serene lake surrounded by crystalline formations", "crystallakeshore.png", "crystallakeshore2.png");
            newWorld.LocationAt(1, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(3));
            newWorld.LocationAt(1, 0).AddMonster(4, 100);





            return newWorld;
        }
    }
}
