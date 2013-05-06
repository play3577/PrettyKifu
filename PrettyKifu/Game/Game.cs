
using System;

namespace PrettyKifu.Game
{    
    public class GoGame
    {
        public GameNode GameTree {get; private set;}
        public GameInfo GameInfo {get; private set;}
        
        public GoGame(GameInfo info, GameNode node)
        {
            GameTree = node;
            GameInfo = info;
        }
    }
}
