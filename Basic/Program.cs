namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Name = "Rifat";
            Console.WriteLine(Name);

            //tarnary operator
            const string ab = Name == "Rifat" ? "OK" : "NOO";
            Console.WriteLine(ab);

            //Array
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}