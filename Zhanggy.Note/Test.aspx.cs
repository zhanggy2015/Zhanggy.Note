using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zhanggy.Note
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string strTmp = "abcdefg某某某";
            //int i = System.Text.Encoding.Default.GetBytes(strTmp).Length;
            //int j = strTmp.Length;
            //Response.Write(i + "-" + j+"-"+ System.Text.Encoding.Default.GetBytes(strTmp));
            //String t = "";

            //string str = String.Format(MyCulture, "My amount = {0:c}", y);

            //Class1 o1 = new Class1();
            //Class1 o2 = new Class1();

            //Response.Write(Class1.Count);


            Class2 o = new Class2();
            o.MethodA();

        }
    }

    //class Class1
    //{
    //    public static int Count = 0;
    //    static Class1()
    //    {
    //        Count++;
    //    }
    //    public Class1()
    //    {
    //        Count++;
    //    }
    //}


    abstract class BaseClass
    {
        public virtual void MethodA()
        {
            Console.WriteLine("BaseClass");
        }
        public virtual void MethodB()
        {
        }
    }
    class Class1 : BaseClass
    {
        public void MethodA()
        {
            Console.WriteLine("Class1");
        }
        public override void MethodB()
        {
        }
    }
    class Class2 : Class1
    {
        new public void MethodB()
        {
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Class2 o = new Class2();
            o.MethodA();
        }
    }

}