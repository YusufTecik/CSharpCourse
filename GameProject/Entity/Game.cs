using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entity
{
    public class Game : IBaseGameService
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GamePrice { get; set; }
    }
}
