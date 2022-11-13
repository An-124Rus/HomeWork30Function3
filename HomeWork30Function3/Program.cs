internal class Program
{
    private static void Main(string[] args)
    {
        int number = ReturnNumber();

        Console.WriteLine("Конвертация 1 удалась. Ваше число - " + number);

        number = ReturnNumber2();

        Console.WriteLine("Конвертация 2 удалась. Ваше число - " + number);
    }

    static int ReturnNumber()
    {
        int number;
        string userInput;

        do
        {
            Console.Write("Введите целое число: ");
            userInput = Console.ReadLine();
        } while (int.TryParse(userInput, out number) == false);

        return number;
    }
    
    static int ReturnNumber2()
    {
        Console.Write("Введите число: ");
        string userInput = Console.ReadLine();
        int number;

        while (int.TryParse(userInput, out number) == false)
        {
                Console.Write("Конвертация не удалась или введено неверное чиcло. Введите число снова: ");
                userInput = Console.ReadLine();
        }

        return number;
    }
}