namespace CG_BTBuoi14
{
    public class Eagle : Animal, IFly
    {
        public override void Sound()
        {
            Console.WriteLine($"{Name} says Screech!");
        }
        public void Fly()
        {
            Console.WriteLine($"{Name} is flying.");
        }
    }
}
