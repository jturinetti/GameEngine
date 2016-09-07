using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GameModels;

namespace GameEngine
{
    public abstract class Game
    {
        protected Timer TimeToAct { get; private set; }

        protected virtual int Turn { get; set; }

        protected virtual IList<Player> Players { get; private set; }

        private readonly GameConfiguration _gameConfiguration;

        public Game(GameConfiguration gameConfiguration)
        {
            _gameConfiguration = gameConfiguration;
            TimeToAct = new Timer(TimerTick, state: null, dueTime: Timeout.Infinite, period: Timeout.Infinite);
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

        public virtual void TimerTick(object state)
        {
            // TODO
        }   
    }
}
