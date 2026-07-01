namespace CG_BTBuoi14
{
    public class Boat : Vehicle
    {
        public Boat(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }
        public override void Move()
        {
            Console.WriteLine($"{Brand} is sailing at {Speed} km/h.");
        }
    }
}
