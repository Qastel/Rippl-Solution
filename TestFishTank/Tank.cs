using System.Collections;
using FishTank;
using NUnit.Framework;

namespace Test1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void TestTank(double expectedFood, Fish[] fishList)
        {
            Tank tank = new Tank();
            tank.AddFish(fishList);

            Assert.AreEqual(expectedFood, tank.Feed());
        }


        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(0.9, new Fish[] { new GoldFish("Jerry"), new AngelFish("Anna"), new BabelFish("Tomy"), new BabelFish("Jacob") });

                yield return new TestCaseData(0.3, new Fish[] { new GoldFish("Jerry"), new AngelFish("Anna")});

                yield return new TestCaseData(0, null);

                yield return new TestCaseData(0, new Fish[] { });

            }
        }

    }
}