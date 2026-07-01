namespace CG_BTBuoi14
{
    public class Player : Character, IDamageable, IInteractable
    {
        public Player(string name, int hp)
        {
            Name = name;
            HP = hp;
        }
        public override void Attack()
        {
            Console.WriteLine($"{Name} is attacking.");
        }
        public void TakeDamage(int damage)
        {
            HP -= damage;
            Console.WriteLine($"{Name} took {damage} damage. Remaining HP: {HP}");
            if (HP <= 0)
            {
                Console.WriteLine($"{Name} dead.");
            }
        }
        public void Interact()
        {
            Console.WriteLine($"{Name} is interacting.");
        }
    }
}
