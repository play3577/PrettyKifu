
using System;
using PrettyKifu.Board;

namespace PrettyKifu.Game.CellActions
{    
    public class SetLabelAction: ICellAction
    {
        public string Label {get; set;}
        
        public SetLabelAction(string label)
        {
            Label = label;
        }
        
        public void Apply(BoardCell cell)
        {
           cell.Label = Label;
        }
    }
}
