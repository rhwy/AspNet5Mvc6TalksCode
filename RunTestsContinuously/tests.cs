//https://github.com/rhwy/AspNet5Mvc6TalksCode
namespace RunningMyFirstTestContinuously
{
  using Xunit;
  using NFluent;
  using System;

  public class Tests
  {
    [Fact]
    public void should_say_hello()
    {
      //put "world" in message to pass your first test!
      var message = "";
      var actual = $"hello {message}";
      var expected = "hello world";
      Check
        .That(actual)
        .IsEqualTo(expected);
    }
  }
}
