using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameEngine;

namespace Samples.Solitaire
{
    public class SolitaireGameConfiguration : GameConfiguration
    {
        public SolitaireGameConfiguration(string name) : base(name)
        {
            TurnPhases = new List<TurnPhase>
            {
                new TurnPhase("Main", 1)
            };            
        }

        public override string GameName
        {
            get { return "Solitaire"; }
        }        
    }
}
