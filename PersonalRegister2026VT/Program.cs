namespace PersonalRegister2026VT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a name for your robot: ");
            string name = Console.ReadLine();

            Robot robot = new Robot(name, 67, 25000);
            //robot._name = "C3PO";
            //robot.SetName("C3PO");
            robot.Age = 1;
            //robot.Salary = 25000;
            Console.WriteLine(robot.GetName());
            Console.WriteLine(robot.Age);
            Console.WriteLine(robot.Salary);


            Console.ReadKey();
        }
    }
}
