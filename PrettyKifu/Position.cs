using System;

namespace PrettyKifu
{
    
    public class Position
    {
        public int X {get; private set;}
        public int Y {get; private set;}
        
        public bool IsEmpty
        {
            get
            {
                return X == int.MinValue || Y == int.MinValue;
            }
        }
        
        public static Position Empty
        {
            get
            {
                return new Position(int.MinValue, int.MinValue);
            }
        }
        
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public override bool Equals(object obj)
        {
            Position other = obj as Position;
            if (other == null)
                return false;
            return this.X == other.X && this.Y == other.Y;
        }
        
        public static bool operator ==(Position lhs, Position rhs)
        {
            if (ReferenceEquals(lhs, rhs))
                return true;
            if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null))
                return false;
            return lhs.Equals(rhs);
        }
        
        public static bool operator !=(Position lhs, Position rhs)
        {
            return !(lhs == rhs);
        }
        
        public override string ToString()
        {
            if (IsEmpty)
                return "[]";
                    
            return string.Format("[{0}, {1}]", X, Y);
        }

        public override int GetHashCode()
        {                        
            return X ^ (Y << (sizeof(int) * 4));
        }


    }
}
