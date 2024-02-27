using Xunit;

namespace CounterChallenge
{
    public class CounterChallengeUnitTests
    {
        [Fact]
        public void GetOutput_SampleInput1_CorrectOutput()
        {
            CounterChallenge counterChallenge = new CounterChallenge();
            string input = "It was many and many a year ago";

            string output = counterChallenge.GetOutput(input);

            Assert.Equal("I0t w1s m2y a1d m2y a y2r a1o", output);
        }

        [Fact]
        public void GetOutput_SampleInput2_CorrectOutput()
        {
            CounterChallenge counterChallenge = new CounterChallenge();
            string input = "Copyright,Microsoft:Corporation";

            string output = counterChallenge.GetOutput(input);

            Assert.Equal("C7t,M6t:C6n", output);
        }

        [Fact]
        public void GetOutput_SampleInput3_CorrectOutput()
        {
            CounterChallenge counterChallenge = new CounterChallenge();
            string input = "Google Bing|Yahoo-Yandex^DuckDuckGo";

            string output = counterChallenge.GetOutput(input);

            Assert.Equal("G3e B2g|Y3o-Y4x^D5o", output);
        }

        [Fact]
        public void GetOutput_SampleInput4_CorrectOutput()
        {
            CounterChallenge counterChallenge = new CounterChallenge();
            string input = "mahomes1kelce2hardman3clark4butker";

            string output = counterChallenge.GetOutput(input);

            Assert.Equal("m5s1k3e2h4n3c3k4b4r", output);
        }
    }
}