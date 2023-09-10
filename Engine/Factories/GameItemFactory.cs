using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class GameItemFactory
    {
        private static List<GameItem> _standardGameItems;
        static GameItemFactory()
        {
            _standardGameItems = new List<GameItem>
            {
                new Weapon(1001, "Rusty Blade", 100, 10, 20),
                new Weapon(1002, "Rusty Stick", 10, 5, 10),
                new GameItem(9001, "Snake Skin", 5),
                new GameItem(9002, "Snake Fang", 2)
            };
        }
        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardGameItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
            if(standardGameItem != null)
            {
                return standardGameItem.Clone();
            }
            return null;
        }
    }
}
