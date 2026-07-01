namespace CG_BTBuoi14
{
    public class Archer : Character
    {
        public Archer(string name, int hp)
        {
            Name = name;
            HP = hp;
        }
        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with a bow and arrow!");
        }
    }
}
