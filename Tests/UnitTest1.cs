namespace Tests
{
    using Xunit;
    using solid;
    public class RegexExtensionsTests
    {
        [Theory]
        [InlineData("hello world", @"\b\w{5}\b", "hello")]
        [InlineData("abc123", @"\d+", "123")]
        [InlineData("nothing", @"\d+", "")] // Нет совпадения, ожидаем пустую строку
        public void FingStrRegex_Should_Return_CorrectMatch(string input, string pattern, string expected)
        {
            // Act
            var result = input.FindStrRegex(pattern);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("User: John", @"User:\s(?<name>\w+)", "name", "John")]
        [InlineData("Age: 25", @"Age:\s(?<age>\d+)", "age", "25")]
        [InlineData("No match", @"User:\s(?<name>\w+)", "name", "")] // Группа не найдена, ожидаем пустую строку
        public void FingStrRegex_WithGroup_Should_Return_CorrectGroupValue(
            string input, string pattern, string groupName, string expected)
        {
            // Act
            var result = input.FindStrRegex(pattern, groupName);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}