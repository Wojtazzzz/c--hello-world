public abstract class Animal
{
    // accessible only within Animal and 'child' classes 
    protected int Age; 
    // private string SomethingUnaccessible = null;
    
    public abstract void Roar();

    public void Eat()
    {
        Console.WriteLine("(onomatopoeic expression of eating)");
    }
}