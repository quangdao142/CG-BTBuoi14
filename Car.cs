namespace CG_BTBuoi14
{
    public class Car : Vehicle
    {
        public Car(string brand, int speed)
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
