namespace FactorialLibrary.Tests;
using FactorialLibrary;
public class FactorialServiceTests
{
    [Fact]
    public void Test_negative()
    {
        Assert.Throws<InvalidOperationException>(()=>{
            var result = FactorialService.Factorial (-1);
        });
    }
}