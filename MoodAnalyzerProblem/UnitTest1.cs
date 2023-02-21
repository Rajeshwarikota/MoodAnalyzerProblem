using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using MoodAnalyzer;

namespace MoodAnalyzerTestProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMood_SholuldreturnSad()
        {
            //Arrange
            Mood_Analyzing Mood = new Mood_Analyzing("sad");

            //Act
            string Expextedresult = "sad";

            //Assert
            string Actualresult = Mood.Analyzingmood();

            Assert.AreEqual(Expextedresult, Actualresult);

        }
    }
}