namespace Lab01_Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        int x1 = 0;
        int y1 = 0;
        int x2 = 0;
        int y2 = 3;
        int x3 = 4;
        int y3 = 0;
        double perimeter = ConsoleApp2.Program.CalculatePerimeter(x1, y1, x2, y2, x3, y3);
        double area = ConsoleApp2.Program.CalculateArea(x1, y1, x2, y2, x3, y3);
        Assert.AreEqual(12, perimeter);
        Assert.AreEqual(6, area);
    }
}
