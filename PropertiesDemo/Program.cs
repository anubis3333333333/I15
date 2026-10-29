Console.WriteLine("демонстрация");

// Person p = new Person("Чоран", 78 , "choranchik@gmail.ru");
// p.PrintInfo();
// Console.WriteLine();
// Console.WriteLine("меняем данные");

// p.Age = 22;
// p.Name = "Дугин";
// p.Email = "alex@mail.ru";

// p.PrintInfo();


// Console.WriteLine("id");
// Person p1 = new Person("Ницше", 18 , "ubermensch@gmail.ru");
// Console.WriteLine($"{p1.Id} p1.Id");


Product p1 = new Product("Веселая наука книга", 1000m,"Философия и литература");
Product p2 = new Product("Основы геополитики", 200000m, "Политика и исскуство");

p1.PrintInfo();
p2.PrintInfo();


Console.WriteLine();

p1.ApplyDiscount(10m);
p2.ApplyDiscount(25m);

p1.PrintInfo();
p2.PrintInfo();

