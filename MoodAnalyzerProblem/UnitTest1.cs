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
        [TestMethod]
        public void GivenAnyMood_SholuldreturnHappy()
        {
            //Arrange
            Mood_Analyzing Mood = new Mood_Analyzing("I am in Any mood");

            //Act
            string Expextedresult = "happy";

            //Assert
            string Actualresult = Mood.Analyzingmood();

            Assert.AreEqual(Expextedresult, Actualresult);

        }

        [TestMethod]
        public void GivenNullMood_SholuldreturnHappy()
        {
            try
            {
                //Arrange
                Mood_Analyzing Mood = new Mood_Analyzing("Null");

                //Act
                string Expextedresult = "happy";

                //Assert
                string Actualresult = Mood.Analyzingmood();

                Assert.AreEqual(Expextedresult, Actualresult);
            }
            catch (NullReferenceException ex)
            {
                Assert.AreEqual("Mood should not be null", ex.Message);
            }

        }

        [TestMethod]
        public void Given_Null_Mood_Sholuld_throw_MoodAnalysisException()
        {
            try
            {
                //Arrange
                Mood_Analyzing Mood = new Mood_Analyzing("Null");

                //Act
                string Expextedresult = "happy";

                //Assert
                string Actualresult = Mood.Analyzingmood();

                Assert.AreEqual(Expextedresult, Actualresult);
            }
            catch (ModalAnalysisExceptin  ex)
            {
                Assert.AreEqual("Mood should not be null", ex.Message);
            }

        }
        [TestMethod]
        public void Given_Empty_Mood_Sholuld_throw_MoodAnalysisException()
        {
            try
            {
                //Arrange
                Mood_Analyzing Mood = new Mood_Analyzing(string.Empty);

                //Act
              //  string Expextedresult = "happy";

                //Assert
                string Actualresult = Mood.Analyzingmood();

               // Assert.AreEqual(Expextedresult, Actualresult);
            }
            catch (ModalAnalysisExceptin ex)
            {
                Assert.AreEqual("Mood should not be empty", ex.Message);
            }

        }

    }
}