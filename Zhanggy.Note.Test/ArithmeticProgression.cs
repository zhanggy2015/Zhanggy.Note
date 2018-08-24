namespace Zhanggy.Note.Test
{
    /// <summary>
    ///求和数列： 1-2+3-4+……+m  
    /// </summary>
    public class ArithmeticProgression
    {
        /* 
         *用等差数列求和公式来解：Sn=n*a1+n(n-1)d/2或Sn=n(a1+an)/2
        解法一：
        1-2+3-4+5-6+……+99-100
        =(1-2)+(3-4)+(5-6)+……+(97-98)+(99-100)
        =(-1)X100/2=-50
        解法二：
        1-2+3-4+5-6+……+99-100
        =（1+3+5+……97+99）+（-2-4-6-……-98-100）
        =（1+99）X50/2+（-2-100）X50/2
        =100X50/2+（-102）X50/2
        =（100-102）X50/2=-2X50/2=-50
        */
        public static double sumArithmeticPro(double targetNum)
        {
            double sum = 0;
            for (double i = 0; i < targetNum + 1; i++)
            {
                if ((i % 2) == 1)
                {
                    sum += i;
                }
                else
                {
                    sum -= i;
                }
            }

            //or
            bool flag = true;
            for (double i = 1; i <= targetNum; i++)
            {
                if (flag)
                {
                    sum += i;
                }
                else
                {
                    sum -= i;
                }
                flag = !flag;
            }

            return sum;
        }
    }
}
