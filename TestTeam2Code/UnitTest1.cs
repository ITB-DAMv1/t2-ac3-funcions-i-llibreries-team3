namespace TestTeam2Code;
using MyProgram;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [DataRow(4, 1, 1)]
    [DataRow(4, 1, 4)]
    [DataRow(4, 1, 2)]
    [DataRow(50000, 1000, 1000)]
    [DataRow(50000, 1000, 50000)]
    [DataRow(50000, 1000, 2000)]
    public void TestRangeTrue(int maxRange, int minRange, int userNum)
    {         
        //Act, Assert
        Assert.IsTrue(Program.CheckRange(maxRange, minRange, userNum));
    }
    [TestMethod]
    [DataRow(4, 1, 0)]
    [DataRow(4, 1, 5)]
    [DataRow(50000, 1000, 500)]
    [DataRow(50000, 1000, 200000)]
    public void TestRangeFalse(int maxRange, int minRange, int userNum)
    {
        //Act, Assert
        Assert.IsFalse(Program.CheckRange(maxRange, minRange, userNum));
    }
}
