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
        Assert.IsTrue(Program.CheckNumber(maxRange, minRange, userNum));
    }

    [TestMethod]
    [DataRow(4, 1, 0)]
    [DataRow(4, 1, 5)]
    [DataRow(50000, 1000, 500)]
    [DataRow(50000, 1000, 200000)]
    public void TestRangeFalse(int maxRange, int minRange, int userNum)
    {
        //Act, Assert
        Assert.IsFalse(Program.CheckNumber(maxRange, minRange, userNum));
    }

    [TestMethod]
    [DataRow("abcdefg1234567")]
    [DataRow("abcdefg")]
    [DataRow("1234567")]
    [DataRow("a1b2c3d4e5f6g7")]
    public void TestSpeCharFalse(string userName)
    {
        //Act, Assert
        Assert.IsFalse(Program.CheckSpecialChar(userName));
    }

    [TestMethod]
    [DataRow("abcdefg1234567-/·")]
    [DataRow("àb/c(de)f%$g")]
    [DataRow("$1234#567")]
    [DataRow("#a@1b!2c|3d*4+e-5f6g7")]
    public void TestSpeCharTrue(string userName)
    {
        //Act, Assert
        Assert.IsTrue(Program.CheckSpecialChar(userName));
    }

    [TestMethod]
    [DataRow("abcdefg1234567")]
    [DataRow("abcdefg")]
    [DataRow("a1b2c3d4e5f6g7")]
    public void TestNameLenghtTrue(string userName)
    {
        //Act, Assert
        Assert.IsTrue(Program.CheckUserNameLenght(userName));
    }

    [TestMethod]
    [DataRow("abcdfg123456789hijklmnopqrstvwxyz")]
    [DataRow("abcdfghijklsdmnopqrfdsdstvwxyzfdsf")]
    [DataRow("a")]
    [DataRow("")]
    public void TestNameLenghtFalse(string userName)
    {
        //Act, Assert
        Assert.IsFalse(Program.CheckUserNameLenght(userName));
    }

    [TestMethod]
    [DataRow("Hola", 2)]
    [DataRow("a", 1)]
    [DataRow("b", 0)]
    [DataRow("Hastaluegoidespuesi", 10)]
    [DataRow("", 0)]
    [DataRow("ABCDEFG", 2)]
    public void TestCountVowels(string userName, int expectedResult)
    {
        // Arrange
        char[] vowels = { 'A', 'E', 'I', 'O', 'U' };
        int numVowels = 0;

        // Act
        Program.CountVowels(userName, vowels, ref numVowels);

        // Assert
        Assert.AreEqual(expectedResult, numVowels);
    }

    [TestMethod]
    [DataRow(0, 10, 40, 0)]
    [DataRow(2, 10, 40, 10)]
    [DataRow(3, 0, 100, 25)]
    [DataRow(1, 0, 20, 0)]
    [DataRow(5, 50, 80, 20)]
    public void TestDistributeDust(int numVowels, int initialDust, int userMaldat, int expectedDust)
    {
        // Arrange
        int polsMagica = initialDust;

        // Act
        Program.DistributeDust(ref polsMagica, numVowels, userMaldat);

        // Assert
        Assert.AreEqual(expectedDust, polsMagica);
    }
}
