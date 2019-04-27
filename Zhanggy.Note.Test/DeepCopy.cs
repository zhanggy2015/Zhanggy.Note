using System;

namespace Zhanggy.Note.Test
{
    public class DeepCopy : ICloneable
    {
        public int _i = 0;
        public A _a = new A();

        /// <summary>
        /// 实现深复制
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            DeepCopy newObj = new DeepCopy();
            newObj._i = _i;
            newObj._a = new A();
            newObj._a._s = _a._s;
            return newObj;
        }

        /// <summary>
        /// 实现浅复制
        /// </summary>
        /// <returns></returns>
        public new object MemberwiseClone()
        {
            return base.MemberwiseClone();
        }
    }

    public class A
    {
        public string _s = "copy test!";
    }
}
