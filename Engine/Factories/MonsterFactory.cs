﻿using System;
using Engine.Models;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster snake =
                        new Monster("Snake", "Snake.png", 2, 2, 0, 2, 2, 1);

                    AddLootItem(snake, 9001, 60);
                    AddLootItem(snake, 9002, 40);

                    return snake;

                case 2:
                    Monster rat =
                        new Monster("Rat", "Rat.png", 5, 3, 0, 2, 3, 5);

                    AddLootItem(rat, 9003, 25);
                    AddLootItem(rat, 9004, 75);

                    return rat;

                case 3:
                    Monster giantSpider =
                        new Monster("Giant Spider", "GiantSpider.png", 10,5, 0, 4, 10, 10);

                    AddLootItem(giantSpider, 9005, 25);
                    AddLootItem(giantSpider, 9006, 75);

                    return giantSpider;

                case 4:
                    Monster Demon =
                        new Monster("Demon Dragon", "demon.png", 100, 30, 0, 15, 100, 150);
                    AddLootItem(Demon, 9007, 20);

                    return Demon;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }

        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RNG.NumberBetween(1, 10) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }
    }
}