namespace CG_BTBuoi14
{
    public abstract class Character
    {
        public string Name;
        public int HP;

        public void Move()
        {
            Console.WriteLine($"{Name} is moving.");
        }

        public abstract void Attack();
    }
}
