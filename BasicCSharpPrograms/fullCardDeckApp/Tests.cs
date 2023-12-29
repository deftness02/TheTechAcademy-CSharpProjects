using Blackjack;
using CardGame;
using NUnit.Framework;

namespace TestGame;

public class Tests
{
    // Create a test for the main program using NUnit
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void MainTest()
        {
            // Arrange
            var expected = 0;
            var actual = 0;
            
            // Act
            actual = 0;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
    
    // Create a test for the Player class
    [TestFixture]
    public class PlayerTests
    {
        [Test]
        public void PlayerTest()
        {
            // Arrange
            var expected = 0;
            var actual = 0;

            // Act
            actual = 0;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayerNameTest()
        {
            // Create a test that adds a player name and make sure game.Player is greater than 0
            // Arrange
            var expected = 0;
            var actual = 0;
            
            // Act
            var player = new Player("Test", 100);
            Game game = new BlackjackGame();
            game += player;
            actual = game.Players.Count;
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
    // Create a test for the Game class
    
    // Create a test for the BlackjackGame class
    
    // Create a test for the Deck class
    
    // Create a test for the Card class
    
    // Create a test for the Dealer class
    
    // Create a test for the IWalkAway interface
    
    
}