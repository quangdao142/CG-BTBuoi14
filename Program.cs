using CG_BTBuoi14;

Console.WriteLine("\nBai 1: Animal");
Animal dog = new Dog();
dog.Name = "Buddy";
dog.Eat();
dog.Sound();

Animal cat = new Cat();
cat.Name = "Mieo";
cat.Eat();
cat.Sound();

Duck duck = new Duck();
duck.Name = "Donald";
duck.Eat();
duck.Sound();

Console.WriteLine("\nBai 2: Vehicle");
Vehicle car = new Car("Ford", 120);
car.Start();
car.Move();
car.Stop();

Vehicle bike = new Bike("Audi", 20);
bike.Start();
bike.Move();
bike.Stop();

Vehicle boat = new Boat("Yamaha", 50);
boat.Start();
bike.Move();
bike.Stop();

Console.WriteLine("\nBai 3: IFly");
Bird bird = new Bird();
bird.Name = "Eagle";
bird.Fly();

Airplane airplane = new Airplane("Boeing", 1000);
airplane.Fly();

Superman superman = new Superman();
superman.Fly();

Console.WriteLine("\nBai 4: Nhieu Interface");
duck.Fly();
duck.Swim();

Fish fish = new Fish();
fish.Swim();

Eagle eagle = new Eagle();
eagle.Name = "Bald Eagle";
eagle.Fly();

Console.WriteLine("\nBai 5: Character");
Warrior warrior = new Warrior("Garen", 100);
warrior.Attack();
Archer archer = new Archer("Vayne", 80);
archer.Attack();
Mage mage = new Mage("Lux", 60);
mage.Attack();

Console.WriteLine("\nBai 6: IDamageable");
Player player = new Player("Player1", 100);
player.TakeDamage(20);
Enemy enemy = new Enemy("Enemy1", 50);
enemy.TakeDamage(50);
Boss boss = new Boss("Boss1", 200);
boss.TakeDamage(150);

Console.WriteLine("\nBai 7: Unity Style");
player.Interact();
Coin coin = new Coin();
coin.Collect();
Chest chest = new Chest();
chest.Interact();

Console.WriteLine("\nBai 8: Employee");
Employee fullTimeEmployee = new FullTimeEmployee("John", 20);
fullTimeEmployee.CalculateSalary();
Employee partTimeEmployee = new PartTimeEmployee("Jane", 15);
partTimeEmployee.CalculateSalary();

Console.WriteLine("\nBai 9: Payment");
CreditCard creditCard = new CreditCard();
creditCard.Pay(100.50m);
PayPal payPal = new PayPal();
payPal.Pay(200.75m);
BankTransfer bankTransfer = new BankTransfer();
bankTransfer.Pay(300.00m);

Console.WriteLine("\nBai 10: Mini RPG");
warrior.Move();
warrior.TakeDamage(50);
mage.Move();
mage.TakeDamage(50);
Healer healer = new Healer("Soraka", 70);
healer.Move();
healer.Attack();
healer.Heal(30);