using System;
using PrettyKifu.Game;
using PrettyKifu.Game.CellActions;

namespace PrettyKifu.Tests.Parsers
{    
    static class GameFactory
    {
                
        public static GameNode SimpleShusakuNode()
        {
            GameNode root = new GameNode();            
            
            var node = root.BlackMove(17, 16);
            node = node.WhiteMove(3, 17);
            node = node.BlackMove(16, 13);
            node = node.WhiteMove(15, 17);
            node = node.BlackMove(3, 4);
            node = node.WhiteMove(17, 5);
            node = node.BlackMove(16, 15);
            node.Name = "Косуми";
            node.MoveAnnotation = MoveAnnotation.Good;
            
            node = node.WhiteMove(17, 10);
            node.Name = "Фусеки Сюсаку";
            node.NodeAnnotation = NodeAnnotation.Even;
            node.MoveNumber = 1;
            node.Comment = "Дальше можно A или B";
            
            node.AddAction(new Position(12, 17), new SetLabelAction("A"));
            node.AddAction(new Position(14, 16), new SetLabelAction("B"));
            node.AddAction(new Position(16, 15), new SetMarkerAction(CellMarker.Circle));
            
            return root;
        }
        
        
        public static GameInfo SimpleShusakuInfo()
        {
            var info = new GameInfo();
            info.Name = "Fuseki Shusaku";
            
            info.WhitePlayerName = "white";
            info.WhitePlayerRank = "9p";
            
            info.BlackPlayerName = "black";
            info.BlackPlayerRank = "9p";
            
            info.Place = "Perm";
            info.Description = "Test";
            info.GameResult = "unfinished";
            
            info.Date = new DateTime(2013, 05, 04);
            
            return info;
        }
        
        static GameNode BlackMove(this GameNode self, int x, int y)
        {
            var node = self.CreateBranch();
            node.Move = new Move(StoneColor.Black, new Position(x, y));
            
            return node;
        }
        
        static GameNode WhiteMove(this GameNode self,int x, int y)
        {
            var node = self.CreateBranch();
            node.Move = new Move(StoneColor.White, new Position(x, y));
            
            return node;
        }
    }
}
