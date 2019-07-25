using System;
using System.Runtime.InteropServices;

namespace Zhanggy.Note.Common
{
    /// <summary>
    /// 调用示例 
    /// private delegate int TestInvoke(string a);
    /// 
    /// DllInvoke dll = new DllInvoke(GetMapPath("~/Bin/a.dll"));
    /// TestInvoke test = (TestInvoke)dll.Invoke("TestInvoke", typeof(TestInvoke));
    /// int resultTemp = test("测试");
    /// </summary>
    public class DllInvoke
    {
        [DllImport("kernel32.dll")]
        private extern static IntPtr LoadLibrary(String path);

        [DllImport("kernel32.dll")]
        private extern static IntPtr GetProcAddress(IntPtr lib, String funcName);

        [DllImport("kernel32.dll")]
        private extern static bool FreeLibrary(IntPtr lib);

        private IntPtr hLib;

        
        public DllInvoke(String DLLPath)
        {
            hLib = LoadLibrary(DLLPath);
        }

        ~DllInvoke()
        {
            FreeLibrary(hLib);
        }

        //将要执行的函数转换为委托  
        public Delegate Invoke(String APIName, Type t)
        {
            IntPtr api = GetProcAddress(hLib, APIName);
            return (Delegate)Marshal.GetDelegateForFunctionPointer(api, t);
        }
    }
}
