namespace aoc2022.tests
{
    public class Day1CalorieCountTests
    {
        [Fact]
        public void ValidDataSingleSuccess()
        {
            // Arrange
            var testData = TestData.Day1CalorieData;

            // Act
            var result = new Day1CalorieCount().GetResult(testData);

            // Assert
            Assert.Equal(24000, result);

        }

        [Fact]
        public void ValidDataForMultipleTopSuccess()
        {
            // Arrange
            var testData = TestData.Day1CalorieData;

            // Act
            var result = new Day1CalorieCount().GetResult(testData,3);

            // Assert
            Assert.Equal(45000, result);

        }

        [Fact]
        public void InvalidDataShouldThrowError()
        {
            // Arrange
            var testData = TestData.Day1CalorieInvalidData;

            // Act, Assert
            Assert.Throws<ArgumentException>(() => _ = new Day1CalorieCount().GetResult(testData));
        }
    }
}