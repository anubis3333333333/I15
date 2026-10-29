Console.WriteLine("демонстрация");

Person p = new Person("Чоран", 78 , "choranchik@gmail.ru");
p.PrintInfo();
Console.WriteLine();
Console.WriteLine("меняем данные");

p.SetAge(22);
p.SetName("Дугин");
p.SetEmail("alex@mail.ru");

p.PrintInfo();