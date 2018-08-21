namespace Zhanggy.Note.DesignMode.Strategy
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior { get; set; }
        public QucakBehavior qucakBehavior { get; set; }
        public Duck() { }

        public abstract void Display();

        public void PerformFly()
        {

            flyBehavior.Fly();//委托行为类
        }

        public void PerformQuack()
        {
            qucakBehavior.Quack();//委托行为类
        }

        public void swim()
        {
            System.Console.WriteLine("All ducks float,even decoys!");
        }

    }

    /// <summary>
    /// /'mælɑːd; -ləd/ 
    /// </summary>
    public class MallardDuck : Duck
    {
        public MallardDuck() {
            flyBehavior = new FlyWithWings();
            qucakBehavior = new Quack();
        }

        public override void Display()
        {
            System.Console.WriteLine("mallard duck");
        }
    }
}
