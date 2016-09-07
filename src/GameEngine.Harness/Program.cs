using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Samples.Solitaire;

namespace GameEngine.Harness
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var game = new SolitaireGame(new SolitaireGameConfiguration("Solitaire")
                {
                    TurnPhases = new List<TurnPhase>
                    {
                        new TurnPhase("Main", 1)
                        {
                            // other properties here                            
                        }
                    }
                }
            );
            
            // TODO
        }
    }
}
