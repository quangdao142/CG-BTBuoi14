namespace CG_BTBuoi14
{
    public abstract class Vehicle
    {
        public string Brand;
        public int Speed;

        public void Start()
        {
            Console.WriteLine($"{Brand} is starting.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} is stopping.");
        }

        public abstract void Move();
    }
}
