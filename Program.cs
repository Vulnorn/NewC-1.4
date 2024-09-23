namespace NewC_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cache;
            string name = "Dronov";
            string surname = "Mikhail";
            string cupTea = "Coffee";
            string cupCoffee = "Tea";

            Console.WriteLine($"До перестановки");
            Console.WriteLine($"Ваше имя {name} фамилия {surname}") ;
            Console.WriteLine($"В чашке с чаем {cupTea} В чашке с кофе {cupCoffee}");

            cache = name;
            name = surname;
            surname = cache;
            cache = cupTea;
            cupTea= cupCoffee;
            cupCoffee = cache;

            Console.WriteLine($"После перестановки");
            Console.WriteLine($"Ваше имя {name} фамилия {surname}");
            Console.WriteLine($"В чашке с чаем {cupTea} В чашке с кофе {cupCoffee}");
        }
    }
}