/// <summary>
/// 单例模式：1 构造函数私有化 2.永远只有一个实例化对象,并提供一个全局访问点
/// </summary>
namespace Zhanggy.Note.DesignMode.Singleton
{
    /// <summary>
    /// 静态构造函数方式
    /// </summary>
    public class Singleton
    {
        private static Singleton intance;
        private Singleton() { }

        static Singleton() {
            //由CLR保证只实例化一次
            intance = new Singleton();
        }

        public static Singleton Intance() {
            return intance;
        }
    }

    /// <summary>
    /// 静态对象方式
    /// </summary>
    public class SingletonSecond {

        //由CLR保证只实例化一次
        private static SingletonSecond intance = new SingletonSecond();
        private SingletonSecond() { }

        public static SingletonSecond Intance() {
            return intance;
        }
    }

    /// <summary>
    /// 双判断加锁
    /// </summary>
    public class SingletonThird {

        private readonly static object objLock=new object();
        private static SingletonThird intance;
        private SingletonThird() { }

        public static SingletonThird Intance() {
            if (intance==null)
            {
                lock (objLock) {
                    if (intance == null)
                        intance = new SingletonThird();
                }
            }
            return intance;
        }
    }
}
