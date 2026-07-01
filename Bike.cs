namespace CG_BTBuoi14
{
    public class Bike : Vehicle
    {
        public Bike(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }
        public override void Move()
        {
            Console.WriteLine($"{Brand} is moving at {Speed} km/h.");
        }
    }
}
