using System;
using PrettyKifu.Board;

namespace PrettyKifu.Game.CellActions
{    
    public class SetMarkerAction: ICellAction
    {
        public CellMarker Marker {get; private set;}
        public SetMarkerAction(CellMarker marker)
        {
            Marker = marker;
        }
        
        public void Apply(BoardCell cell)
        {
            cell.Marker = Marker;
        }
        
        public override string ToString()
        {
            return string.Format("[Set Marker: {0}]", Marker);
        }

    }
}
