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
        public static World CreateWorld()
        {
            World newWorld = new World();



            newWorld.AddLocation(0, 0,
            "Papaya Grove",
            "Home",
            "PapayaGrove.png");

            newWorld.AddLocation(-1, 0,
            "PapayaCaverns",
            "You see a cave!",
            "PapayaCaverns.png");
            newWorld.LocationAt(-1, 0).AddMonster(1, 100);

            newWorld.AddLocation(-2, 0,
            "Papaya Enclave",
            "You see a bountiful of papaya's!",
            "PapayaEnclave.png");
            newWorld.LocationAt(-2, 0).AddMonster(2, 100);

            newWorld.AddLocation(-2, 1,
            "PapayaIsles",
            "Rows of papaya's stand before you!",
            "PapayaIsles.png");


            newWorld.AddLocation(-1, -1,
            "Papaya Oasis",
            "You see paradise in the form of a papaya!",
            "PapayaOasis.png");
            
            newWorld.LocationAt(-1, -1).TraderHere =
                TraderFactory.GetTraderByName("Farmer Ted");

            newWorld.AddLocation(1, 0,
            "PapayaPalace",
            "You see the heart of nolan!",
            "PapayaPalace.png");

            newWorld.AddLocation(2, 0,
            "PapayaPeak",
            "You are on top of a papaya",
            "PapayaPeak.png");
            newWorld.LocationAt(2, 0).AddMonster(4, 100);

            newWorld.AddLocation(1, -1,
            "PapayaPlains",
            "Seedlings of papaya plants stand before you",
            "PapayaPlains.png");
            newWorld.LocationAt(1, -1).AddMonster(5, 100);

            newWorld.AddLocation(1, -2,
            "PapayaSprings",
            "You're in a spring, made out of papaya juice",
            "PapayaSprings.png");

            newWorld.AddLocation(2, -2,
            "The Great Papaya",
            "You are inside of a papaya.",
            "TheGreatPapaya.jpg");
            newWorld.LocationAt(2, -2).AddMonster(6, 100);

            

            return newWorld;


        }
    }
