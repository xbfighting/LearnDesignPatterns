using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 单例模式（Singleton）
 * 保证一个类仅有一个实例，并提供一个访问他的全局访问点。
 * 
 * 单例模式试图解决如下两个问题
 * 1、全局访问
 * 2、实例化控制
 */

namespace Singleton
{
    /// <summary>
    /// Singleton_Normal（懒汉模式）
    /// <remarks>当多线程时则会导致同一时间产生多个实例</remarks>
    /// </summary>
    public class Singleton_Normal
    {
        private static Singleton_Normal instance;

        private Singleton_Normal()
        {
        }

        public static Singleton_Normal GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton_Normal();
            }
            return instance;
        }
    }

    /// <summary>
    /// 多线程时可以保证不会产生多个实例 （懒汉模式）
    /// <remarks>性能不好</remarks>
    /// </summary>
    public class SingletonLocking
    {
        private static SingletonLocking instance;

        /// <summary>
        /// 程序运行时创建一个静态制度的进程辅助
        /// </summary>
        private static readonly object syncRoot = new object();

        private SingletonLocking()
        {
        }

        public static SingletonLocking GetInstance()
        {
            /*
             * lock是确保当一个线程位于代码的临界区时，另一个线程不进入临界区。
             * 如果其他线程试图进入锁定的代码，则他将一直等待（即被阻止），直到该对象被释放。
             */

            // 在同一个时刻，加了锁的那部分，程序只有一个线程可以进入
            lock (syncRoot)
            {
                if (instance == null)
                {
                    instance = new SingletonLocking();
                }
            }
            return instance;
        }
    }

    /// <summary>
    /// 双重锁定 （懒汉模式）
    /// </summary>
    public class Singleton_Double_Check_Locking
    {
        private static Singleton_Double_Check_Locking instance;

        /// <summary>
        /// 程序运行时创建一个静态制度的进程辅助
        /// </summary>
        private static readonly object syncRoot = new object();

        private Singleton_Double_Check_Locking()
        {
        }

        public static Singleton_Double_Check_Locking GetInstance()
        {
            // 只在实例未被创建的时候再加锁处理
            if (instance == null)
            {
                /*
                 * lock是确保当一个线程位于代码的临界区时，另一个线程不进入临界区。
                 * 如果其他线程试图进入锁定的代码，则他将一直等待（即被阻止），直到该对象被释放。
                 */

                // 在同一个时刻，加了锁的那部分，程序只有一个线程可以进入
                lock (syncRoot)
                {
                    // 防止多次创建实例
                    if (instance == null)
                    {
                        instance = new Singleton_Double_Check_Locking();
                    }
                }
            }

            return instance;
        }

        /// <summary>
        /// 静态初始化 单例（饿汉模式）
        /// <remarks>sealed 防止被派生，而派生可能会增加实例</remarks>
        /// </summary>
        public sealed class Singleton_Static_Instance
        {
            /// <summary>
            /// readonly 在第一次引用类的任何成员时创建实例，公共语言运行库负责处理变量初始化
            /// </summary>
            private static readonly Singleton_Static_Instance instance = new Singleton_Static_Instance();

            private Singleton_Static_Instance()
            {
            }

            public static Singleton_Static_Instance GetInstance()
            {
                return instance;
            }
        }
    }
}

/*
 * 饿汉 vs 懒汉
 * 由于饿汉模式，即静态初始化的方式，它是类一加载就实例化的对象，所以要提前占用系统资源。
 * 然而懒汉模式，又会面临着多线程访问的安全性问题，需要做双重锁定这样的处理才可以保证安全。
 * 所以到底使用哪一种方式，取决于实际的需求。从C#语言角度来讲，饿汉式的单例类已经足够满足我们的需求了。
 */
