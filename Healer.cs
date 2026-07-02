namespace CG_BTBuoi14
{
    public class Healer : Character, IHealable
    {
        public Healer(string name, int hp)
        {
            Name = name;
            HP = hp;
        }
        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with a staff!");
        }
        public void Heal(int amount)
        {
            HP += amount;
            Console.WriteLine($"{Name} heals for {amount}. Current HP: {HP}");
        }
    }
}
