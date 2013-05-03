using System;
using PrettyKifu.Game.CellActions;

namespace PrettyKifu.Board
{
    public class BoardCell
    {   
        public StoneType Stone {get; set;}
        public string Label {get; set;}
        public CellMarker Marker {get; set;}
        
        public BoardCell()
        {
            Stone = StoneType.Empty;
            Label = "";
            Marker = CellMarker.None;
        }
    }
}
