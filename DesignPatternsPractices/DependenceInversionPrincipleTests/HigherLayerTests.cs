using NUnit.Framework;

namespace DependenceInversionPrinciple.Tests
{
    [TestFixture]
    public class HigherLayerTests
    {
        [Test]
        public void Test_DogDaliy()
        {
            // given 
            var expected = new Dog();

            // when
            var result = new HigherLayer("DOG").GetAnimal();
            
            // then

            Assert.AreEqual(expected.GetType(), result.GetType());
        }

        [Test]
        public void Test_PigDaliy()
        {
            // given 
            var expected = new Pig();

            // when
            var result = new HigherLayer("PIG").GetAnimal();

            // then

            Assert.AreEqual(expected.GetType(), result.GetType());
        }
    }
}