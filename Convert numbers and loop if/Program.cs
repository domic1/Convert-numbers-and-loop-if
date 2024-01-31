namespace Done_is_better_than_good
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            Console.WriteLine("Podaj pierwszą cyfrę");
            double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Podaj drugą cyfrę");
            double.TryParse(Console.ReadLine(), out number2);

            Console.WriteLine("Suma tych liczb jest równa:" + (number1 + number2));
            Console.WriteLine("Wynik z dzielenia jest równy :" + (number1 / number2));
        }
    }
}
