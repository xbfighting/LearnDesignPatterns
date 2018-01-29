//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strategy_SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Strategy_SimpleFactory.Tests
{
    [TestFixture]
    public class ContextTests
    {
        [Test]
        public void Test_CashNormal()
        {
            // given
            double money = 99d;
            double expected = 99d;

            // when 
            var cxt = new Context("正常收费");
            double result = cxt.AcceptCash(money);

            // then 
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_CashRebate()
        {
            // given
            double money = 99d;
            double expected = 99*0.9;

            // when 
            var cxt = new Context("打九折");
            double result = cxt.AcceptCash(money);

            // then 
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_CashReturn()
        {
            // given
            double money = 99d;
            double expected = 96d;

            // when 
            var cxt = new Context("满30减1");
            double result = cxt.AcceptCash(money);

            // then 
            Assert.AreEqual(expected, result);
        }
    }
}