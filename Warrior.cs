namespace CG_BTBuoi14
{
    public class Warrior : Character
    {
        public Warrior(string name, int hp)
        {
            Name = name;
            HP = hp;
        }
        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with a sword!");
        }
    }
}
