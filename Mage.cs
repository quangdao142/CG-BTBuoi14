namespace CG_BTBuoi14
{
    public class Mage : Character, IDamageable
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
        public void TakeDamage(int damage)
        {
            HP -= damage;
            Console.WriteLine($"{Name} takes {damage} damage. Remaining HP: {HP}");
            if (HP <= 0)
            {
                Console.WriteLine($"{Name} has been defeated!");
            }
        }
    }
}
