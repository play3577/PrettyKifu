
using System;

namespace PrettyKifu.Game
{
    
    public class GameInfo
    {
        public string Name {get; set;}
        public string Description {get; set;} 
        
        public DateTime Date {get; set;}
        public string Place {get; set;}
        
        public string ByoYomiDescription {get; set;}
        
        public int BoardSize{get; set;}
                
        public string BlackPlayerName {get; set;}
        public string BlackPlayerRank{get; set;}

        public string WhitePlayerName {get; set;}
        public string WhitePlayerRank{get; set;}
        
        public string GameResult{get; set;}
        
        public string Author {get;set;}
        
        public GameInfo()
        {
        }
    }
}
