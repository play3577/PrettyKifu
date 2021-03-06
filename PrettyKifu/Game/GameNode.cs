﻿using System;
using System.Collections.Generic;

namespace PrettyKifu.Game
{    
    
    public enum MoveAnnotation
    {
        None,
        Bad,
        Good, 
        Doubtful,
        Interesting                
    }
    
    public enum NodeAnnotation
    {
        None,
        GoodForWhite,
        GoodForBlack,
        Even,
        Hotspot,
        Unclear
    }
    
    public class GameNode
    {                
        public string Name{get; set;}
        public string Comment{get; set;}
        public Move Move{get; set;}
        public int? MoveNumber {get; set;}
        
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

        private readonly List<KeyValuePair<Position, ICellAction>> actions = new List<KeyValuePair<Position, ICellAction>>();
        public IEnumerable<KeyValuePair<Position, ICellAction>> CellActions
        {
            get
            {
                return actions;
            }
        }       
        
        public GameNode()
        {
            Name = "";
            Comment = "";
            Move = null;
            MoveNumber = null;
            MoveAnnotation = MoveAnnotation.None;
            NodeAnnotation = NodeAnnotation.None;
        }
                       
        public void AddAction(Position position, ICellAction action)
        {            
            actions.Add(new KeyValuePair<Position, ICellAction>(position, action));
        }
        
        public GameNode CreateBranch()
        {
            GameNode branch = new GameNode();
            branches.Add(branch);
            
            return branch;
        }       
        
    }
}
