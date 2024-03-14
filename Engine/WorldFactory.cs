using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public class WorldFactory
    {
        internal World CreatWorld()
        {
             World newWorld = new World();

            newWorld.AddLocation(0, 0,
                "Papaya Grove",
                "A lush forest where towering papaya trees grow abundantly, their ripe fruits hanging like golden lanterns amidst the emerald foliage. The air is sweet with the scent of papayas, and magical creatures roam freely among the branches.",
                "pack://application:,,,/Engine;component/Images/Location/Papaya Grove.jpg");

            newWorld.AddLocation(0, 1,
                "Papaya Palace",
                "A grand citadel constructed entirely of enchanted papaya stones, gleaming with a warm, orange hue under the sun. Within its walls, wizards and scholars study the mystical properties of papayas and harness their powers for spells and potions.",
                "pack://application:,,,/Engine;component/Images/Location/papaya palacejpg");

            newWorld.AddLocation(0, 2,
                "Papaya isles",
                "A lush forest where towering papaya trees grow abundantly, their ripe fruits hanging like golden lanterns amidst the emerald foliage. The air is sweet with the scent of papayas, and magical creatures roam freely among the branches.",
                "pack://application:,,,/Engine;component/Images/Location/Papaya isles.jpg");

            newWorld.AddLocation(1, 1,
                "Papaya Enclave",
                "A bustling city built around a central marketplace overflowing with exotic papaya varieties from every corner of the realm. Here, merchants haggle over the finest papaya delicacies, while street performers entertain the crowds with mesmerizing papaya-themed performances.",
                "pack://application:,,,/Engine;component/Images/Location/Papaya Enclave.jpg");

            newWorld.AddLocation(1, 0,
                "Papaya Plains",
                "Vast stretches of rolling plains dotted with wild papaya orchards, where nomadic tribes of papaya farmers roam with their herds of magical creatures. The plains are alive with color and song, as festivals celebrating the papaya harvest are held beneath the open sky.",
                "pack://application:,,,/Engine;component/Images/Location/Papaya Plains.jpg");

            newWorld.AddLocation(-1, 1,
                "Papaya Oasis",
                "A tranquil oasis nestled within the heart of a scorching desert, where a single majestic papaya tree stands tall amid the shimmering sands. Travelers stumble upon this oasis by chance, finding respite from the blistering heat and discovering the secrets of the mystical fruit that sustains life in the barren wasteland.",
                "pack://application:,,,/Engine;component/Images/Location/Papaya oasis.jpg");

            newWorld.AddLocation(-1, 0,
                "Papaya Caverns",
                "Dark and mysterious underground tunnels lined with glowing papaya vines that illuminate the twisting passageways. Treasure hunters and adventurers brave the depths in search of the legendary Papaya Crystal, said to grant unimaginable powers to whoever possesses it.",
                "pack://application:,,,/Engine;component/Images/Location/Papaya Caverns.jpg");

            newWorld.AddLocation(0, 0,
                "Papaya Springs",
                "Hidden deep within a mystical jungle, these sacred springs bubble with rejuvenating papaya-infused waters. Travelers journey from afar seeking the healing properties of these enchanted waters, which are said to restore youth and vitality.",
                "pack://application:,,,/Engine;component/Images/Location/Papaya Springs.jpg");

            newWorld.AddLocation(-2, 2,
                "Papaya Peak",
                "The highest mountain in the land, its summit crowned with a giant papaya-shaped crystal that glows with ethereal light. Legends tell of the ancient guardian spirits who reside atop Papaya Peak, watching over the realm and bestowing wisdom upon those who seek it.",
                "pack://application:,,,/Engine;component/Images/Location/Papaya peak.jpg");


            return newWorld;
        }
    }
}
