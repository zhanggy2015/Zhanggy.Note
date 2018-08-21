namespace Zhanggy.Note.DesignMode.Strategy
{
    public interface QucakBehavior
    {
        void Quack();
    }

    public class Quack : QucakBehavior
    {
        void QucakBehavior.Quack()
        {
            System.Console.WriteLine("quack");
        }
    }

    public class MuteQuack : QucakBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("silence");
        }
    }

    public class Squeak : QucakBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("Squeak");
        }
    }
}
