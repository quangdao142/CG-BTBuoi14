namespace CG_BTBuoi14
{
    public class Mage : Character
    {
        public Mage(string name, int hp)
        {
            Name = name;
            HP = hp;
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with a magic wand!");
        }
    }
}
