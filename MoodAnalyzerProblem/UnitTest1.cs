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
                //string Expextedresult = "happy";

                //Assert
                string Actualresult = Mood.Analyzingmood();

                //  Assert.AreEqual(Expextedresult, Actualresult);
            }
            catch (ModalAnalysisExceptin ex)
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
        [TestMethod]
        public void Given_MoodAnalysis_Classname_should_Return_MoodAnalysis_obj()
        {


            object expected = new Mood_Analyzing();
            object obj = MoodAnalyzerFactory.CreateMoodAnalyserObject("MoodAnalyzer.Mood_Analyzing", "Mood_Analyzing");
            expected.Equals(obj);


        }
        [TestMethod]
        public void Given_Improper_Classname_should_Return_MoodAnalysis_obj()
        {
            try
            {

                object expected = new Mood_Analyzing();
                object obj = MoodAnalyzerFactory.CreateMoodAnalyserObject("MoodAnalyzer.Mood_Analyzing", "Mood_Analyzingobj");
                expected.Equals(obj);

            }
            catch (ModalAnalysisExceptin ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done Test case: WhenGivenClassNameWrong_ThrowsMoodAnalysisException");
            }
        }
        [TestMethod]
        public void Given_Improper_Constructor_should_Return_MoodAnalysis_obj()
        {
            try
            {

                object expected = new Mood_Analyzing();
                object obj = MoodAnalyzerFactory.CreateMoodAnalyserObject("MoodAnalyzing", "MoodAnalyzer.Mood_Analyzing");
                expected.Equals(obj);

            }
            catch (ModalAnalysisExceptin ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done Test case: WhenGivenConstructorWrong_ThrowsMoodAnalysisException");
            }
        }

        [TestMethod]
        public void Given_MoodAnalysis_Classname_should_Return_MoodAnalysis_obj_using_parametrized()
        {
            try
            {

                object expected = new Mood_Analyzing();
                object obj = MoodAnalyzerFactory.CreateMoodAnalyserParameterizedObject("MoodAnalyzing", "MoodAnalyzer.Mood_Analyzing", "Happy");
                expected.Equals(obj);

            }
            catch (ModalAnalysisExceptin ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done Test case: WhenGivenConstructorWrong_ThrowsMoodAnalysisException");
            }
        }
        [TestMethod]
        public void Given_Improper_Classname_should_Return_MoodAnalysis_obj_using_parametrized()
        {
            try
            {

                object expected = new Mood_Analyzing();
                object obj = MoodAnalyzerFactory.CreateMoodAnalyserParameterizedObject("MoodAnalyzing", "MoodAnalyzer.Mood_Analyzingobj", "Happy");
                expected.Equals(obj);

            }
            catch (ModalAnalysisExceptin ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            finally
            {
                Console.WriteLine("Done Test case: WhenGivenClassnameWrong_ThrowsMoodAnalysisException");
            }

        }
        [TestMethod]
        public void Given_Improper_Constructor_should_Return_MoodAnalysis_obj_using_parametrized()
        {
            try
            {

                object expected = new Mood_Analyzing();
                object obj = MoodAnalyzerFactory.CreateMoodAnalyserParameterizedObject("MoodAnalyzing", "Happy", "MoodAnalyzer.Mood_Analyzingobj");
                expected.Equals(obj);

            }
            catch (ModalAnalysisExceptin ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            finally
            {
                Console.WriteLine("Done Test case: WhenGivenConstructorWrong_ThrowsMoodAnalysisException");
            }
        }

        [TestMethod]
        public void Given_ModalAnalyzer_using_Reflection_Invoke_Method()
        {
            //string message = "I am in happy mood";
            //string methodName = "AnalyzeMood";
            //string excepted = "happy";
            //string expectedmsg = "method not found";
            //string actual = "";
            try
            {
                //actual = MoodAnalyzerFactory.InvokeAnalyseMood(message, methodName);
                //Assert.AreEqual(excepted, actual);
                object expected = new Mood_Analyzing();
                object obj = MoodAnalyzerFactory.InvokeAnalyseMood("I am in Happy mood","Mood_Analyzing");
                expected.Equals(obj);
            }
            catch (ModalAnalysisExceptin ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            finally
            {
                Console.WriteLine("Done Test case: Method not found");
            }
        }
    }
}