class Contact {
    private static int nextId = 1;
    private string firstName;
    private string lastName;
    private string phone;
    private string email;

    public int Id {get; private set;}
    public string Notes {get; set;}

    public string FirstName{
        get {
            return firstName;

        }
        set{
            if (value == null || value.Trim()== ""){
                Console.WriteLine("ошибка");
                return;
            }
            firstName = value;
        }
    }


    public string LastName{
        get {
            return lastName;

        }
        set{
            if (value == null || value.Trim()== ""){
                Console.WriteLine("ошибка");
                return;
            }
            lastName = value;
        }
    }


    public string Email{
        get {
            return email;

        }
        set{
            if (value == null || !value.Contains("@")){
                Console.WriteLine("ошибка");
                return;
            }
            email = value;
        }
    }


    public string Phone{
        get {
            return phone;

        }
        set{
            if (value == null || value.Trim()== ""){
                Console.WriteLine("ошибка");
                return;
            }
            if (value.Length < 5){
                Console.WriteLine("ошибка");
                return;
            }
            phone = value;
        }
    }


    public Contact(string firstName, string lastName, string phone , string email){
        Id = nextId;
        nextId++;
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
        Email = email;
        Notes = "";

    }

    public string GetFullName(){
        return $"{FirstName} {LastName}";
    }

    public void PrintInfo(){
        Console.WriteLine($"[{Id}] {GetFullName()}");
        Console.WriteLine(Phone);
        Console.WriteLine(Email);
        if (Notes != ""){
            Console.WriteLine($"заметка - .{Notes}.");
        }
    }

}