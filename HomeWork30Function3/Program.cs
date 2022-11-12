internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        string userInput = Console.ReadLine();

        FindNumber(userInput, out int number);

        Console.WriteLine("Конвертация удалась. Ваше число - " + number);
    }

    static void FindNumber(string userInput, out int number)
    {
        bool isWorking = true;
        number = 0;

        while (isWorking)
        {
            int.TryParse(userInput, out number);

            if (number == 0)
            {
                Console.Write("Конвертация не удалась или введено неверное чиcло. Введите число снова: ");
                userInput = Console.ReadLine();
            }
            else
            {
                isWorking = false;
            }
        }
    }
}