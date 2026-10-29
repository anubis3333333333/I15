Console.WriteLine("демонстрация");

Person p = new Person("Чоран", 78 , "choranchik@gmail.ru");
p.PrintInfo();
Console.WriteLine();
Console.WriteLine("меняем данные");

p.Age = 22;
p.Name = "Дугин";
p.Email = "alex@mail.ru";

p.PrintInfo();