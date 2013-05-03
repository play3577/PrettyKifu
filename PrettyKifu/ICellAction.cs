using System;
using PrettyKifu.Board;

namespace PrettyKifu
{   
    public interface ICellAction
    {
        void Apply(BoardCell cell);
    }
}
