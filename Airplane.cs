namespace CG_BTBuoi14
{
    public class Airplane : Vehicle, IFly
    {
        public Airplane(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }
        public void Fly()
        {
            Console.WriteLine($"{Brand} is flying at {Speed} km/h.");
        }
        public override void Move()
        {
            Fly();
        }
    }
}
