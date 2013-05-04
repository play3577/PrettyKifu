using System;
using System.Text;
using PrettyKifu.Game.CellActions;

namespace PrettyKifu.Board
{
    public class BoardCell
    {   
        public StoneType Stone {get; set;}
        public string Label {get; set;}
        public CellMarker Marker {get; set;}
        public Position Position{get; private set;}
        
        public BoardCell(Position position)
        {
            Stone = StoneType.Empty;
            Label = "";
            Marker = CellMarker.None;
            Position = position;
        }
        
        public override bool Equals(object obj)
        {
            BoardCell other = obj as BoardCell;
            if (other == null)
                return false;
            return this.Stone == other.Stone 
                && this.Label == other.Label 
                && this.Marker == other.Marker 
                && object.Equals(this.Position, other.Position);
        }
        
        public static bool operator ==(BoardCell lhs, BoardCell rhs)
        {
            if (ReferenceEquals(lhs, rhs))
                return true;
            if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null))
                return false;
            return lhs.Equals(rhs);
        }
        
        public static bool operator !=(BoardCell lhs, BoardCell rhs)
        {
            return !(lhs == rhs);
        }
        
        public override int GetHashCode()
        {
            int hashCode = 0;
            unchecked {
                hashCode += 1000000007 * Stone.GetHashCode();
                if (Label != null)
                    hashCode += 1000000009 * Label.GetHashCode();
                hashCode += 1000000021 * Marker.GetHashCode();
                if (Position != null)
                    hashCode += 1000000033 * Position.GetHashCode();
            }
            return hashCode;
        }

        
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Cell {0}", Position);
            builder.AppendLine();
            if (Marker != CellMarker.None)
            {
                builder.AppendFormat("Marker: {0}", Marker);
                builder.AppendLine();
            }
            
            if (!string.IsNullOrEmpty(Label))
            {
                builder.AppendFormat("Label: {0}", Marker);
                builder.AppendLine();
            }
            
            if (Stone != StoneType.Empty)
            {
                builder.Append("Empty");
            }
            else
            {
                builder.AppendFormat("{0} stone", Stone);
            }
            
            return builder.ToString();
        }


    }
}
