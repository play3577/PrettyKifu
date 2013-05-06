using System;
using System.IO;
using NUnit.Framework;
using PrettyKifu.Game;
using PrettyKifu.Parsers;

namespace PrettyKifu.Tests.Parsers
{
    [TestFixture]
    public class SGFParserTest
    {
        public SGFParserTest()
        {
        }
        
        [Test]
        public void SimpleTest()
        {
            GoGame expectedGame = new GoGame(GameFactory.SimpleShusakuInfo(), GameFactory.SimpleShusakuNode());
                  
            Stream stream = File.OpenRead(@"parsers\sgf\simplegame.sgf");
            
            var parser = new SGFParser();
            var game = parser.Parse(stream);
            
            Assert.AreEqual(expectedGame, game);
        }
        
    }
}
