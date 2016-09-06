using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameEngine
{
    public class TurnPhase
    {
        public string PhaseName { get; private set; }

        public int Order { get; private set; }

        public TurnPhase(string name, int order)
        {
            PhaseName = name;
            Order = order;
        }        
    }
}
