using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Controller
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Abu";
            CurrentPlayer.Category = "Fighter";
            CurrentPlayer.ExperiencePoints = 10;
            CurrentPlayer.HitPoints = 20;
            CurrentPlayer.Level = 1;
            CurrentPlayer.Gold = 100000;
        }
    }
}
