namespace CG_BTBuoi14
{
    public abstract class Animal
    {
        public string Name;

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public abstract void Sound();
    }
}
