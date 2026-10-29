class Person{
    private string name;
    private int age;
    private string email;


    public Person(string name , int age, string email){
        this.name = name;
        this.age = age;
        this.email = email;


    }

    public string GetName() {return name;}
    public int GetAge() {return age;}
    public string GetEmail () {return email;}


    public void SetName(string value){
        if (value == null || value.Trim() == ""){
            Console.WriteLine("ошибка");
            return;
        }
        name = value;
    }

    public void SetAge(int value){
        if (value < 0 || value > 150){
            Console.WriteLine("ошибка");

        }
        age = value;
    }

    public void SetEmail(string value){
        if (value == null || !value.Contains("@")){
            Console.WriteLine("ошибка");
            return;
        }
        email = value;
    }

    public void PrintInfo(){
        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(email);

    }
}