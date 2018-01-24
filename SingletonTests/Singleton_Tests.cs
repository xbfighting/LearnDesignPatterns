//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Singleton.Tests
{
    [TestFixture]
    public class Singleton_Tests
    {
        [Test]
        public void Test_Normal_GetInstance()
        {
            // given
            var instance0 = Singleton_Normal.GetInstance();

            // when
            var instance1 = Singleton_Normal.GetInstance();

            // then
            Assert.AreEqual(instance1.GetHashCode(), instance0.GetHashCode());
        }

        /// <exception cref="ThreadStateException">线程已启动。</exception>
        [Test]
        public void Test_Normal_MultiThread_GetInstance()
        {
            // given
            int sameHashCount = 1000;
            int sameHashCount2 = 1000;
            var list = new List<Singleton_Normal>();

            for (int i = 0; i < sameHashCount; i++)
            {
                var t = new Thread(() =>
                {
                    list.Add(Singleton_Normal.GetInstance());
                });
                t.Start();
            }

            // 等待所有实例都生成好
            Thread.Sleep(5000);

            // when 
            foreach (var item1 in list)
            {
                foreach (var item2 in list)
                {
                    if (item1.GetHashCode() != item2.GetHashCode())
                    {
                        sameHashCount2 -= 1;
                        break;
                    }
                }
            }

            // then
            Assert.AreEqual(sameHashCount, sameHashCount2);
        }


        [Test]
        public void Test_Locking_GetInstance()
        {
            // given
            var instance0 = Singleton_Locking.GetInstance();

            // when
            var instance1 = Singleton_Locking.GetInstance();

            // then
            Assert.AreEqual(instance1.GetHashCode(), instance0.GetHashCode());
        }
        
        /// <exception cref="ThreadStateException">线程已启动。</exception>
        [Test]
        public void Test_Locking_MultiThread_GetInstance()
        {
            // given
            int sameHashCount = 1000;
            int sameHashCount2 = 1000;
            var list = new List<Singleton_Locking>();

            for (int i = 0; i < sameHashCount; i++)
            {
                var t = new Thread(() =>
                {
                    list.Add(Singleton_Locking.GetInstance());
                });
                t.Start();
            }

            // 等待所有实例都生成好
            Thread.Sleep(5000);

            // when 
            foreach (var item1 in list)
            {
                foreach (var item2 in list)
                {
                    if (item1.GetHashCode() != item2.GetHashCode())
                    {
                        sameHashCount2 -= 1;
                        break;
                    }
                }
            }

            // then
            Assert.AreEqual(sameHashCount, sameHashCount2);
        }

        [Test]
        public void Test_Double_Check_Locking_GetInstance()
        {
            // given
            var instance0 = Singleton_Double_Check_Locking.GetInstance();

            // when
            var instance1 = Singleton_Double_Check_Locking.GetInstance();

            // then
            Assert.AreEqual(instance1.GetHashCode(), instance0.GetHashCode());
        }


        [Test]
        public void Test_Static_GetInstance()
        {
            // given
            var instance0 = Singleton_Static_Instance.GetInstance();

            // when
            var instance1 = Singleton_Static_Instance.GetInstance();

            // then
            Assert.AreEqual(instance1.GetHashCode(), instance0.GetHashCode());
        }


        /// <exception cref="ThreadStateException">线程已启动。</exception>
        [Test]
        public void Test_Static_MultiThread_GetInstance()
        {
            // given
            int sameHashCount = 1000;
            int sameHashCount2 = 1000;
            var list = new List<Singleton_Static_Instance>();

            for (int i = 0; i < sameHashCount; i++)
            {
                var t = new Thread(() =>
                {
                    list.Add(Singleton_Static_Instance.GetInstance());
                });
                t.Start();
            }

            // 等待所有实例都生成好
            Thread.Sleep(5000);

            // when 
            foreach (var item1 in list)
            {
                foreach (var item2 in list)
                {
                    if (item1.GetHashCode() != item2.GetHashCode())
                    {
                        sameHashCount2 -= 1;
                        break;
                    }
                }
            }

            // then
            Assert.AreEqual(sameHashCount, sameHashCount2);
        }
    }
}