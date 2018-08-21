namespace Zhanggy.Note.DesignMode.Strategy
{
    public interface FlyBehavior
    {
        void Fly();
    }

    public class FlyWithWings : FlyBehavior
    {

        public void Fly()
        {
            //实现飞行为，给真的鸭子用
            System.Console.WriteLine("I can fly.");
        }
        
    }

    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            //给不会飞的鸭子用
            System.Console.WriteLine("I can not fly.");
        }
    }
}
