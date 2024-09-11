namespace NamedAndOptionalParamaters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayWelcome(repeat: 5, message: "welcome");
        }

        static void SayWelcome(string message = "hi", int repeat = 5)
        {
            for (int i = 0; i < repeat; i++)
            {
                Console.WriteLine(message);
            }
        }

    }
}
