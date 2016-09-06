using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameEngine
{
    public abstract class GameConfiguration
    {
        public GameConfiguration(string name)
        {
            GameName = name;
        }

        public virtual string GameName { get; set; }

        public virtual IList<TurnPhase> TurnPhases { get; set; }
    }
}
