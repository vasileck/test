public class FindSumTests
{
    [Fact]
    public void FindSum_ReturnsCorrectSum_ForValidArray()
    {
        int[] input = { 4, 0, 3, 19, 492, -10, 1 };
        int result = Program.FindSum(input);
        Assert.Equal(-10, result); 
    }

    [Fact]
    public void FindSum_ThrowsException_ForEmptyArray()
    {
        int[] input = { };
        Assert.Throws<ArgumentException>(() => Program.FindSum(input));
    }

    [Fact]
    public void FindSum_ThrowsException_ForSingleElementArray()
    {
        int[] input = { 42 };
        Assert.Throws<ArgumentException>(() => Program.FindSum(input));
    }

    [Fact]
    public void FindSum_WorksWithLargeArray()
    {
        int[] input = new int[100_000_000];
        input[0] = -100;
        input[1] = -200;
        int result = Program.FindSum(input);
        Assert.Equal(-300, result);
    }
}