namespace CG_BTBuoi14
{
    public class Bird : Animal, IFly
    {
        public void Fly()
        {
            Console.WriteLine($"{Name} is flying.");
        }
        public override void Sound()
        {
            Console.WriteLine($"{Name} is chirping.");
        }
    }
}
