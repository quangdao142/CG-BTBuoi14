namespace CG_BTBuoi14
{
    public class Duck : Animal, IFly, ISwim
    {
        public override void Sound()
        {
            Console.WriteLine($"{Name} says Quack!");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying.");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming.");
        }
    }
}
