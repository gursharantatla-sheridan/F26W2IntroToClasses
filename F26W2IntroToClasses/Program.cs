namespace F26W2IntroToClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.SetId(100);
            p1.Name = "Keyboard";
            p1.Price = 30;

            Console.WriteLine("p1.id = " + p1.GetId());
            Console.WriteLine("p1.name = " + p1.Name);
            Console.WriteLine("p1.price = " + p1.Price);


            Product p2 = new Product(101, "Laptop", 1200);

            Product p3 = new();
            Product p4 = new(102, "Mobile", 2000);

            //var p5 = new();
            var p6 = new Product();

            Product p7 = new Product() { Name = "Table", Price = 50 };

            Student s1 = new Student("John", "Smith");
        }
    }
}
