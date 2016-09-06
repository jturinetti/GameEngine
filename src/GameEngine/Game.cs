using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameModels;

namespace GameEngine
{
    public abstract class Game
    {
        protected virtual int Turn { get; set; }

        protected virtual IList<Player> Players { get; private set; }

        private readonly GameConfiguration _gameConfiguration;

        public Game(GameConfiguration gameConfiguration)
        {
            _gameConfiguration = gameConfiguration;
        }        

        public virtual void StartTurn()
        {
            Turn++;
            
            foreach (var phase in _gameConfiguration.TurnPhases)
            {
                // TODO
            }
        }

        public virtual void EndTurn()
        {
            // TODO
        }
    }
}
