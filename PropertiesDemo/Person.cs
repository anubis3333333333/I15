class Person{
    private string name;
    private int age;
    private string email;
    private static int nextId = 1;
    public int Id {get; private set;}

    public string Name {
        get {
            return name;
        }
        set {
            if (value == null || value.Trim() == ""){
                Console.WriteLine("ошибка");
                return;
            }
            name = value;
        }
    }

    public int Age {
        get {
            return age;
        }
        set{
            if (value < 0 || value > 150){
                Console.WriteLine("ошибка");
            }
            age = value;
        }
    }

    public string Email {
        get {
            return email;

        }
        set {
            if (value == null || !value.Contains("@")){
                Console.WriteLine("ошибка");
                return;
            }
            email = value;
        }
    }

    public Person(string name, int age, string email){
        Id = nextId;
        nextId++;
        Name = name;
        Age = age;
        Email = email;
    }

    public void PrintInfo(){
        Console.WriteLine(Name);
        Console.WriteLine(Age);
        Console.WriteLine(Email);
    }

}