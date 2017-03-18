using Xunit;

namespace DemoTravis.Tests
{
  public class UnitTest1
  {
    [Fact]
    public void Test1()
    {
      int i = 10;

      int j = Foo(i);

      Assert.Equal(10, j);

      int Foo(int x) => x;
    }
  }
}
