//using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SimpleFactoryPattern.Tests
{
    [TestFixture]
    public class OperationFactoryTests
    {
        private Operation _operation;

        [SetUp]
        public void SetUp()
        {
            _operation = new Operation
            {
                NumberA = 10,
                NumberB = 1,
            };
        }

        [Test]
        public void Test_CreateOperate_Add()
        {
            // given
            double expectedResult = 11;

            var operation = OperationFactory.CreateOperate("+");
            operation.NumberA = _operation.NumberA;
            operation.NumberB = _operation.NumberB;

            // when
            double result = operation.GetResult();

            // then
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Test_CreateOperate_Sub()
        {
            // given
            double expectedResult = 9;

            var operation = OperationFactory.CreateOperate("-");
            operation.NumberA = _operation.NumberA;
            operation.NumberB = _operation.NumberB;

            // when
            double result = operation.GetResult();

            // then
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Test_CreateOperate_Mul()
        {
            // given
            double expectedResult = 10;

            var operation = OperationFactory.CreateOperate("*");
            operation.NumberA = _operation.NumberA;
            operation.NumberB = _operation.NumberB;

            // when
            double result = operation.GetResult();

            // then
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Test_CreateOperate_Div()
        {
            // given
            double expectedResult = 10;

            var operation = OperationFactory.CreateOperate("/");
            operation.NumberA = _operation.NumberA;
            operation.NumberB = _operation.NumberB;

            // when
            double result = operation.GetResult();

            // then
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Test_CreateOperate_Empty()
        {
            // given
            double expectedResult = 0;

            var operation = OperationFactory.CreateOperate("");
            operation.NumberA = _operation.NumberA;
            operation.NumberB = _operation.NumberB;

            // when
            double result = operation.GetResult();

            // then
            Assert.AreEqual(expectedResult, result);
        }

        // TODO: Exception test
        //[Test]
        //    public void Test_CreateOperate_Div_Zero()
        //    {
        //        // given
        //        var expectedResult = new Exception("除数不能为0。");

        //        var operation = OperationFactory.CreateOperate("");
        //        operation.NumberA = _operation.NumberA;
        //        operation.NumberB = 0;

        //        //// when
        //        var ex = Assert.Throws<Exception>(delegate { operation.GetResult(); });
        //        //// then

        //        //Assert.AreEqual(ex.Message, expectedResult.Message);
        //        //Assert.Throws(expectedResult.GetType(), delegate { operation.GetResult(); });
        //        Assert.Throws(typeof (Exception), delegate { operation.GetResult(); });
        //    }
    }
}