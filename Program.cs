namespace Assignment_3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Enter the First number: "); 
            double num1 = double.Parse(Console.ReadLine()); 

            Console.Write("Enter the Second number: "); 
            double num2 = double.Parse(Console.ReadLine()); 

            Console.Write("Enter the Third number: "); 
            double num3 = double.Parse(Console.ReadLine()); 

            Console.Write("Enter the Fourth number: "); 
            double num4 = double.Parse(Console.ReadLine()); 

            double total = num1 + num2 + num3 + num4;//total = all of the num inputs
            double average = total / 4;//divide by how many numbers there which is 4

			Console.WriteLine($"The average of {num1}, {num2}, {num3}, {num4} is: {average}"); 
            Console.WriteLine($"The total is: {total}");
		}
    }
}
