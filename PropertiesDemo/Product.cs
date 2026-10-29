class Product{
    public int Id {get; private set;}
    public string Name {get; set;}
    public decimal Price {get; set;}
    public string Category {get; set;}

    private static int nextId = 1;

    public Product(string name , decimal price , string category){
        Id = nextId;
        nextId++;
        Name = name;
        Price = price;
        Category = category;
    }

    public void PrintInfo(){
        Console.WriteLine($"[{Id}] {Name} - {Price} руб ({Category})");
    }

    public void ApplyDiscount(decimal percent){
        if (percent <= 0 || percent >= 100){
            Console.WriteLine("ошибка");
            return;
        }
        Price = Price * (1 - percent / 100);
    }

}