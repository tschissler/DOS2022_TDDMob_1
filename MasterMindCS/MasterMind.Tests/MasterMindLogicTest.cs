using FluentAssertions;
using MasterMind.App;
using NUnit.Framework;

namespace MasterMind.Tests;

public class MasterMindLogicTest
{
    [TestCase("AAAA", "AAAA", "PPPP")]
    [TestCase("ABCD", "ABCD", "PPPP")]
    [TestCase("AAAA", "BBBB", "")]
    [TestCase("AAAB", "AAAA", "PPP")]
    [TestCase("BAAA", "EBCD", "C")]
    [TestCase("ABCD", "DCBA", "CCCC")]
    [TestCase("ABCD", "AEFB", "PC")]
    [TestCase("ABCD", "AAAA", "P")]
    [TestCase("AAAA", "ABCD", "P")]
    [TestCase("ABAB", "AABB", "PPCC")]
    [TestCase("ABAA", "CCAB", "PC")]
    [TestCase("ABCD", "ADBA", "PCC")]
    [TestCase("GEFA", "EGEF", "CCC")]
    public void GetGuessFeedbackTest(string code, string input, string expectedResult)
    {
        var result = MasterMindLogic.GetGuessFeedback(code, input);
        result.Should().Be(expectedResult);
    }
}