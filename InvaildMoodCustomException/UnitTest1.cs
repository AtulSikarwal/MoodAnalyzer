namespace Day20MoodAnalyser
{
    public class Tests
    {

        MoodAnalyser moodAnalyser;
        [SetUp]
        public void Setup()
        {
            moodAnalyser = new MoodAnalyser();
        }

        [Test]
        public void GivenMessage_WhenSad_ShouldReturnSadParameterLess_Constructor()
        {
            //Arrange
            moodAnalyser = new MoodAnalyser();
            string msg = "I am in SAD mood";
            //Act
            string message = moodAnalyser.AnalyseMoodWithoutConstructor(msg);
            //Assert
            Assert.AreEqual("SAD", message);
        }

        [Test]
        public void GivenMessage_WhenAnyMood_ShouldReturnHappyParameterLess_Constructor()
        {
            moodAnalyser = new MoodAnalyser();
            string msg = "I am in Any mood";
            string message = moodAnalyser.AnalyseMoodWithoutConstructor(msg);
            Assert.AreEqual("HAPPY", message);
        }

        [Test]
        public void GivenMessage_WhenNull_ShouldReturnHappy()
        {
            moodAnalyser = new MoodAnalyser();
            string message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("SAD", message);
        }

        [Test]
        public void GivenMessage_WhenHappy_ShouldReturnHappy()
        {
            moodAnalyser = new MoodAnalyser("I am in Happy mood");
            string message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", message);
        }

        [Test]
        public void GivenMessage_WhenNull_USingCustomException_ShouldReturnNullMood()
        {
            moodAnalyser = new MoodAnalyser();
            try
            {
                string message = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.NULL_MOOD, exception.exceptionType);
            }

        }

        [Test]
        public void GivenMessage_WhenEmpty_USingCustomException_ShouldReturnNullMood()
        {
            moodAnalyser = new MoodAnalyser("");
            try
            {
                string message = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.EMPTY_MOOD, exception.exceptionType);
            }
        }
    }
}