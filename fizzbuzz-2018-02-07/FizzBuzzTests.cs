using FluentAssertions;
using NUnit.Framework;

namespace fizzbuzz_2018_02_07
{
    [TestFixture]
  public class FizzBuzzTests
  {
    [Test, Category("Unit")]
    public void GivenTwo_WhenAskingToString_ThenItShouldReturnTwo()
    {
      // arrange
      IInteger integer = new Integer(2);

      // act
      string two = $"{integer}";

      // assert
      two.Should().Be("2");
    }

    [Test, Category("Unit")]
    public void GivenSix_WhenAskingToString_ThenItShouldReturnFizz()
    {
      // arrange
      IInteger integer = new Integer(6);

      // act
      string fizz = $"{integer}";

      // assert
      fizz.Should().Be("fizz");
    }
 
    [Test, Category("Unit")]
    public void GivenTen_WhenAskingToString_ThenItShouldReturnBuzz()
    {
      // arrange
      IInteger integer = new Integer(10);

      // act
      string buzz = $"{integer}";

      // assert
      buzz.Should().Be("buzz");
    }
 
    [Test, Category("Unit")]
    public void GivenThirty_WhenAskingToString_ThenItShouldReturnFizzBuzz()
    {
      // arrange
      IInteger integer = new Integer(30);

      // act
      string fizzbuzz = $"{integer}";

      // assert
      fizzbuzz.Should().Be("fizzbuzz");
    }
  }

  public interface IInteger
  {
    string ToString();
  }

  public class Integer : IInteger
  {
    private readonly int _value;

    public Integer(int value)
    {
      _value = value;
    }

    public override string ToString()
    {
      const string fizz = "fizz";
      const string buzz = "buzz";

      if (_value.DivisibleBy(15)) return $"{fizz}{buzz}";
      if (_value.DivisibleBy(5)) return buzz;
      if (_value.DivisibleBy(3)) return fizz;
      return _value.ToString();
    }
  }

  public static class IntExtensions
  {
    public static bool DivisibleBy(this int dividend, int divisor)
    {
      return dividend % divisor == 0;
    }
  }
}