using Census_Analyser;

namespace Census_Test
{
    public class Tests
    {
        StateCensusAnalyser analyser = new StateCensusAnalyser();
        [Test]
        public void Given_TotalCount_When_Compare_Then_return_Positive_Result()
        {
            string path = @"D:\Bridgelabz\.Net\Indian_States_Census_Analyser\Census_Analyser\Files\StateCensusData.csv";
            Assert.AreEqual(29, analyser.Analyser(path));
        }
    }
}