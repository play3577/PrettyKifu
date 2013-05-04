
using System;

namespace PrettyKifu.Game
{    
    public enum StoneColor
    {
        White,
        Black
    }
    
    public class Move
    {
        public Position Position {get; private set;}
        public StoneColor Color {get; private set;}
        
        public bool Pass
        {
            get
            {
                return Position == null || Position.IsEmpty;
            }
        }
        
        public Move(StoneColor color, Position position)
        {
            Position = position;
            Color = color;
        }
        
        public override string ToString()
        {
            string move = Pass ? "pass" : string.Format("at {0}", Position);            
            return string.Format("[Move: {0} {1}]", Color, move);
        }

    }
}
