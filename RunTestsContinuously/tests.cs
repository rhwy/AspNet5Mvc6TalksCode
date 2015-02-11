//https://github.com/rhwy/AspNet5Mvc6TalksCode
using static System.Console;
using Xunit;
using NFluent;
using System;

public class Tests
{
  [Fact]
  public void should_say_hello()
  {
    //put "tests in aspnet5" to pass the test
    var message = "tests in aspnet5";
    var actual = $"hello {message}";
    var expected = "hello tests in aspnet5";
    Check
      .That(actual)
      .IsEqualTo(expected);
  }
}
