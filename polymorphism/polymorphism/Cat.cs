namespace polymorphism;

public sealed class Cat : Animal
{
    public Cat(int age)
    {
        this.Age = age;
    }
    
    public override void Roar()
    {
        Console.WriteLine("Meow!");
    }

    public void Sleep()
    {
        Console.WriteLine("Zzzzz...");
    }
}