namespace HelloWorldDemoProject276Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HelloWorld Program!");
            Console.WriteLine("Push the code on github");   
            Console.WriteLine("Modified in remote repository");
            Console.WriteLine("Modified in local repository");

            //object or instance syntax
            //Classname variable = new Classname
            Human obj = new Human();
            Console.WriteLine("Enter human name");
            obj.name = Console.ReadLine();
            Console.WriteLine("Please enter your height");
            obj.height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter your weight");
            obj.weight = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter your age");
            obj.Age = Convert.ToInt32(Console.ReadLine());
            obj.Speak();
            obj.HumanDetails(obj.name, obj.height, obj.weight, obj.Age);
        }
    }
}
