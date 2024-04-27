namespace MyCalculatorTests
{
    [TestClass]
    public class MyCalcTest

    {
        public TestContext? TestContext { get; set; }
        [TestMethod]
        public void MyCalcProjectAdd_2_4_returns_6()
        {
            int x;
            int y;

            x = int.Parse(TestContext?.Properties?["ValueX"]?.ToString());
            x = int.Parse(TestContext?.Properties?["ValueY"]?.ToString());

            Calculator c = new Calculator();
            int result = c.Add(
                x, y);
            Assert.AreEqual(14, result);
        }
    }
}