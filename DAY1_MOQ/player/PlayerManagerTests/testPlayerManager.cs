using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using PlayersManagerLib;


namespace PlayerManagerTests
{
    [TestFixture]
    public class testPlayerManager
    {
        Mock<IPlayerMapper> mockPlayer;
        
        [SetUp]
        public void init()
        {
            mockPlayer = new Mock<IPlayerMapper>();
            mockPlayer.Setup(m=> m.IsPlayerNameExistsInDb(It.IsAny<string>())).Returns(false);
        }

        [TestCase("Sachin")]
        [TestCase("Virat")]
        public void TestRegisterPlayer(string name)
        {
            Player newPlayer = Player.RegisterNewPlayer(name, mockPlayer.Object);
            Assert.AreEqual(name, newPlayer.Name);
            Assert.AreEqual(43,newPlayer.Age);
            Assert.AreEqual("India",newPlayer.Country);
            Assert.AreEqual(30,newPlayer.NoOfMatches);
        }

    }
}
