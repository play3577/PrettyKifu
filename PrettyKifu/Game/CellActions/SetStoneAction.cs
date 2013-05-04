using System;
using PrettyKifu.Board;

namespace PrettyKifu.Game.CellActions
{
	public class SetStoneAction: ICellAction
	{
	    public StoneType StoneType {get; private set;}	   	    
	    public SetStoneAction(StoneType stoneType)
	    {
	        StoneType = stoneType;
	    }
	    
	    public void Apply(BoardCell cell)
	    {
	        cell.Stone = StoneType;
	    }
	    
	    public override string ToString()
        {
            return string.Format("[Set Stone: {0}]", StoneType);
        }

	   
	}
}
