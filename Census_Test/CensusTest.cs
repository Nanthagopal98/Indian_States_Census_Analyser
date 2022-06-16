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
        [Test]
        public void Given_Incorrect_File_When_Compare_Then_Throw_Exception()
        {
            string path = @"D:\Bridgelabz\.Net\Indian_States_Census_Analyser\Census_Analyser\Files\Code.csv";
            try
            {
                analyser.CensusAdapter(path);
            }
            catch (CustomExceptioncs e)
            {
                Assert.AreEqual("Check File Path or Name", e.Message);
            }
        }
        [Test]
        public void Given_Incorrect_FileType_When_Compare_Then_Throw_Exception()
        {
            string path = @"D:\Bridgelabz\.Net\Indian_States_Census_Analyser\Census_Analyser\Files\StateCensusData.txt";
            try
            {
                analyser.CensusAdapter(path);
            }
            catch (CustomExceptioncs e)
            {
                Assert.AreEqual("Check File Type", e.Message);
            }
        }
        [Test]
        public void Given_Incorrect_Delimiter_FileType_When_Compare_Then_Throw_Exception()
        {
            string path = @"D:\Bridgelabz\.Net\Indian_States_Census_Analyser\Census_Analyser\Files\DelimiterIssue.csv";
            try
            {
                analyser.CensusAdapter(path);

            }
            catch (CustomExceptioncs e)
            {
                Assert.AreEqual("Check Delimiter", e.Message);
            }
        }
        [Test]
        public void Given_Incorrect_Header_File_When_Compare_Then_Throw_Exception()
        {
            string path = @"D:\Bridgelabz\.Net\Indian_States_Census_Analyser\Census_Analyser\Files\HeaderIssue.csv";
            try
            {
                analyser.CensusAdapter(path);

            }
            catch (CustomExceptioncs e)
            {
                Assert.AreEqual("Check Header", e.Message);
            }
        }
        //State Code Tests
        [Test]
        public void Given_StateCode_TotalCount_When_Compare_Then_return_Positive_Result()
        {
            string path = @"D:\Bridgelabz\.Net\Indian_States_Census_Analyser\Census_Analyser\Files\StateCode.csv";
            Assert.AreEqual(37, analyser.StateCodeAnalyser(path));
        }
        [Test]
        public void Given_Incorrect_StateCode_File_When_Compare_Then_Throw_Exception()
        {
            string path = @"D:\Bridgelabz\.Net\Indian_States_Census_Analyser\Census_Analyser\Files\State.csv";
            try
            {
                analyser.StateCodeAnalyser(path);
            }
            catch (CustomExceptioncs e)
            {
                Assert.AreEqual("Check File Name", e.Message);
            }
        }
    }
}