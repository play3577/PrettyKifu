
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
    }
}
