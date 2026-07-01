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

Animal duck = new Duck();
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
