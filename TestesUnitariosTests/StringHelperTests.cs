using System.Linq;
using TestesUnitariosEstudos.Helpers;
using Xunit;

namespace TestesUnitariosTests;

public class StringHelperTests
{
    private readonly StringHelper _stringHelper = new StringHelper();

    [Theory]
    [InlineData("teste", 5)]
    [InlineData("carros", 6)]
    [InlineData("carreta", 7)]
    public void ShouldReturnNumberOfCharacterInWord(string word, int expected)
    {
        var result = _stringHelper.CountCharacters(word);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Jack Bauer", "Jack")]
    [InlineData("Al Pacino", "Al")]
    [InlineData("Um Dois", "Um")]
    [InlineData("Um", "Um")]
    public void ShouldReturnFirstWordBeforeSpace(string text, string expected)
    {
        var result = _stringHelper.GetFirstWordBeforeSpace(text);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Jack Bauer", 2)]
    [InlineData("Al Pacino: Actor", 3)]
    [InlineData("Um, Dois; tres: fim", 4)]
    [InlineData("Um", 1)]
    public void ShouldReturnNumberOfWordsInText(string text, int expected)
    {
        var result = _stringHelper.CountWords(text);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void ShouldReturnOneStringWithJoinedWords()
    {
        var word1 = "Um";
        var word2 = "Dois";
        var expected = "Um Dois";

        var result = _stringHelper.JoinWords(word1, word2);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("Jack Bauer", new[] {"Jack", "Bauer"})]
    [InlineData("Um, Dois; tres: fim", new[] {"Um", "Dois", "tres", "fim"})]
    public void ShouldReturnAListWithAtLeastOneItem(string text, string[] list)
    {
        var expected = list.ToList();
        var result = _stringHelper.ReturnListOfStrings(text);

        Assert.NotEmpty(result);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void ShouldReturnAnEmptyList()
    {
        var text = "";

        var result = _stringHelper.ReturnListOfStrings(text);

        Assert.Empty(result);
    }
}