using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();
        static QuestFactory()
        {

            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();
            itemsToComplete.Add(new ItemQuantity(9001, 5));
            itemsToComplete.Add(new ItemQuantity(9002, 5));
            itemsToComplete.Add(new ItemQuantity(9003, 5));
            itemsToComplete.Add(new ItemQuantity(9004, 5));
            itemsToComplete.Add(new ItemQuantity(9005, 5));
            itemsToComplete.Add(new ItemQuantity(9006, 5));
            itemsToComplete.Add(new ItemQuantity(9007, 5));
            rewardItems.Add(new ItemQuantity(64, 1000));
            rewardItems.Add(new ItemQuantity(65, 1));
            rewardItems.Add(new ItemQuantity(66, 1));
            rewardItems.Add(new ItemQuantity(67, 1));
            rewardItems.Add(new ItemQuantity(68, 1));
            rewardItems.Add(new ItemQuantity(69, 1));
            rewardItems.Add(new ItemQuantity(70, 1)); 

            _quests.Add(new Quest(1,
                                  "The Papaya Plunder: Seek the Absent Glyph of Papaya Buccaneer Fruit",
                                  "Legend has it that amidst Papaya Buccaneer's voyage through the Mango Mist Sea, he misplaced his bounty, leaving behind a symbol.",
                                  itemsToComplete,
                                  25, 10,
                                  rewardItems));
            _quests.Add(new Quest(2,
                                  "Alas, Our Path is Blocked: Forge a Path to Papaya Grove",
                                  "Take on the role of a fruity architect and construct a bridge sturdy enough for a papaya adventurer, but not tempting enough for them to nibble away!" +
                                  "\nThe link between Papaya Grove and Mango River was shattered by a band of Charred Crumbles in a dispute over who was the most burnt among them.",
                                  itemsToComplete,
                                  25, 10,
                                  rewardItems));
            _quests.Add(new Quest(3,
                                  "Papaya Paradise Pact: Ally with Mayor Papaya Leaf Butter",
                                  "Earn the trust of Mayor Papaya Leaf Butter to secure a rare ingredient." +
                                  "nHere's the scoop: There's a mayor residing in Papaya Paradise Province who enjoys papaya leaf butter with his tea. Keep it under wraps! We wouldn't want the fruity folks to catch wind of it!",
                                  itemsToComplete,
                                  25, 10,
                                  rewardItems));
            _quests.Add(new Quest(4,
                                "Papaya Peril: Locate Papaya Puff Cookie and Supply Ingredients for the "Golden Papaya Puff"",
                                "Hunt down Papaya Puff Cookie deep within the Papaya Grove, renowned as the master baker with a golden knack for creating delectable papaya pastries. Word on the vine suggests his treats gleam so bright, you might need shades just to gaze upon them!",
                                itemsToComplete,
                                25, 10,
                                rewardItems));
            _quests.Add(new Quest(5,
                                "Venture to the Papaya Perch: Pursue the Treasure Map Presented by Papaya Buccaneer Cookie",
                                "Embark on a quest to the Crinkled Cove, a dessert land adorned with papaya delights and peculiar peaks, where doubt may cloud your path. Amidst the folds of the Crinkles Dessert lies your sought-after bounty, so set sail on your journey to uncover the treasure.",
                                itemsToComplete,
                                25, 10,
                                rewardItems));
            _quests.Add(new Quest(6,
                                "Papaya Haven: Retrieve Papaya Cream Espresso Essence",
                                "Legend speaks of a sacred place nestled amidst the Papaya Peaks, where the purest essence flows from the heights of Papaya Cream Falls. This concentrated elixir, coveted by many, is said to possess the essence of the papaya fruit itself. Journey forth to claim the Papaya Cream Espresso Essence from its natural source.",
                                itemsToComplete,
                                25, 10,
                                rewardItems));
            _quests.Add(new Quest(7,
                                "Follow the Papaya Oracle: Accompany Golden Prophet Cookie to the Papaya Metropolis",
                                "Embrace the papaya's divine guidance as you journey alongside Golden Prophet Cookie to the heart of the Papaya Metropolis. In surrendering to the fruit's wisdom, let it pave your way. Though locals may find it fruity, even amidst the sands of Tropical Papaya Beach, your purpose shall be revealed..",
                                itemsToComplete,
                                25, 10,
                                rewardItems));
            _quests.Add(new Quest(8,
                                "Papaya Pilgrimage: Deliver the Golden Papaya Puff to Vanilla Cookie",
                                "As you traverse through the divine realms of papaya perfection, remember that the true essence of your quest lies within the heavenly embrace of Papaya Chocolate Haven. And as you embark on this final stretch of your journey, recall that the most rewarding path always leads you back to the sweet familiarity of home.",
                                itemsToComplete,
                                25, 10,
                                rewardItems));
        }
            internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
