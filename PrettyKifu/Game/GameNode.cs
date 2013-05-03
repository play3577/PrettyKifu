using System;
using System.Collections.Generic;

namespace PrettyKifu.Game
{    
    
    public enum MoveAnnotation
    {
    }
    
    public enum NodeAnnotation
    {
    }
    
    public class GameNode
    {                
        public string Name{get; set;}
        public string Comment{get; set;}
        public Move Move{get; set;}
        
        public MoveAnnotation MoveAnnotation{get; set;}
        public NodeAnnotation NodeAnnotation{get; set;}
        
        private readonly List<GameNode> branches = new List<GameNode>();
        public IEnumerable<GameNode> Branches
        {
            get
            {
                return branches;
            }
        }

        private readonly Dictionary<Position, ICellAction> actions = new Dictionary<Position, ICellAction>();
        public IDictionary<Position, ICellAction> CellActions
        {
            get
            {
                return actions;
            }
        }       
        
        
        
        public GameNode()
        {
        }
        
        public void AddBranch(GameNode node)
        {
            branches.Add(node);
        }
        
        public void AddPlacing(Position position, ICellAction placing)
        {
            // Проверять на наличие размещений в эту же позицию
            // что делать при коллизии ?
            actions.Add(position, placing);
        }
               
        
    }
}
