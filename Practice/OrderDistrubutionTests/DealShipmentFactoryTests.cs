using NUnit.Framework;
using OrderDistrubution.Opeartor;

namespace OrderDistrubution.Tests
{
    [TestFixture]
    public class DealShipmentFactoryTests
    {
        [Test]
        public void Test_DealShipmentFactory()
        {
            // given
            int type = 0;
            object dto = 0;

            // when
            var testFactior = new DealShipmentFactory(type, dto);

            // then
            Assert.IsNotNull(testFactior);
        }

        [Test]
        public void Test_FirstShipmentGen()
        {
            // given
            int type = 1;
            object dto = "Test_FirstShipmentGen";

            // when
            var testFactior = new DealShipmentFactory(type, dto);
            testFactior.ShipmentGen();

            // then
            Assert.IsNotNull(testFactior);

            // excepted print
            /*
             * override abstract Console.WriteLine Op1 1!
             * override abstract Console.WriteLine Op2 1!
             * override abstract Console.WriteLine Op3 1!
             * Default Console.WriteLine Default!
             * Test_FirstShipmentGen
             */
        }

        [Test]
        public void Test_FirstShipmentBind()
        {
            // given
            int type = 1;
            object dto = "Test_FirstShipmentBind";

            // when
            var testFactior = new DealShipmentFactory(type, dto);
            testFactior.BindShipment();

            // then
            Assert.IsNotNull(testFactior);

            // excepted print
            /*
             * override abstract Console.WriteLine Op2 1!
             * override abstract Console.WriteLine Op3 1!
             * Test_FirstShipmentBind
             */
        }

        [Test]
        public void Test_SecondShipmentGen()
        {
            // given
            int type = 2;
            object dto = "Test_SecondShipmentGen";

            // when
            var testFactior = new DealShipmentFactory(type, dto);
            testFactior.ShipmentGen();

            // then
            Assert.IsNotNull(testFactior);

            // excepted print
            /*
             * Default Console.WriteLine Default!
             * override abstract Console.WriteLine Op3 2!
             * override abstract Console.WriteLine Op2 2!
             * override abstract Console.WriteLine Op1 2!
             * Test_SecondShipmentGen
             */
        }

        [Test]
        public void Test_SecondShipmentBind()
        {
            // given
            int type = 2;
            object dto = "Test_SecondShipmentBind";

            // when
            var testFactior = new DealShipmentFactory(type, dto);
            testFactior.BindShipment();

            // then
            Assert.IsNotNull(testFactior);

            // excepted print
            /*
             * override abstract Console.WriteLine Op2 1!
             * override abstract Console.WriteLine Op2 1!
             * Test_SecondShipmentBind
             */
        }
    }
}