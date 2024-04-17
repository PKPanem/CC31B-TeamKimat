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

            newWorld.AddLocation(0,0, "Home", "A peaceful village where your journey begins", "Citrus Grove.jpg", "Papaya Grove.png");

            newWorld.AddLocation(0, 1, "Papaya Palace", "The heart of Nolan.", "Papaya palace.png", "Starlit Observatory.jpg");
            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));
            newWorld.LocationAt(0, 1).AddMonster(3, 100);

            newWorld.AddLocation(1, 1, "Celestial Garden", "A beautiful garden filled with papayas.", "celestial garden.jpg", "coral cathedral.jpg");
            newWorld.LocationAt(1, 1).TraderHere = TraderFactory.GetTraderByName("Mysterious Trader");
            newWorld.LocationAt(1, 1).AddMonster(1, 100);

            newWorld.AddLocation(-1, 1, "Forbidden Jungle", "A hidden jungle.", "forbidden jungle.png", "papaya arena.jpg");
            newWorld.LocationAt(-1, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(2));
            newWorld.LocationAt(-1, 1).AddMonster(2, 100);

            newWorld.AddLocation(0, 2, "Papaya Caverns", "A mystical land filled with papaya.", "papaya caverns.png", "papaya enclave.png");
            newWorld.LocationAt(0, 2).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(6));
            newWorld.LocationAt(0, 2).AddMonster(7, 100);

            newWorld.AddLocation(1, 2, "Papaya Isles", "Rows of papaya stand before you.", "papaya isles.png", "papaya labyrinth.jpg");
            newWorld.LocationAt(1, 2).TraderHere = TraderFactory.GetTraderByName("Mystical Merchant");

            newWorld.AddLocation(-1, 2, "Papaya Oasis", "An oasis with papaya juice.", "papaya oasis.png", "papaya peak.png");
            newWorld.LocationAt(-1, 2).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(4));
            newWorld.LocationAt(-1, 2).AddMonster(5, 100);

            newWorld.AddLocation(-1, 0, "Papaya Plains", "A plain field full of papayas.", "papaya plains.png", "papaya springs.png");
            newWorld.LocationAt(-1, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(5));
            newWorld.LocationAt(-1, 0).AddMonster(6, 100);

            newWorld.AddLocation(1, 0, "Papaya Volcano", "A volcano made out of erupting papaya.", "papaya volcano.jpg", "the great papaya.jpg");
            newWorld.LocationAt(1, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(3));
            newWorld.LocationAt(1, 0).AddMonster(4, 100);





            return newWorld;
        }
    }
}
