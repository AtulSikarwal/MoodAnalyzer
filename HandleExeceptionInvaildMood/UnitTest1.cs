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
            
            moodAnalyser = new MoodAnalyser();
            string msg = "I am in SAD mood";
          
            string message = moodAnalyser.AnalyseMoodWithoutConstructor(msg);
          
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
    }
}