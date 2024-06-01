    namespace polymorphism;

    public sealed class Dog : Animal
    {
        // allow to change Dog name everywhere
        // public string Name { get; set; }
        
        // allow to change Dog name only within this class scope
        // public string Name { get; private set; }
        
        // allow to only init Dog name, getter inherit scope 'public' after property
        public string Name { get; }

        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        
        public override void Roar()
        {
            Console.WriteLine("Woof!");
        }
    }