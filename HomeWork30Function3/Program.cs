internal class Program
{
    private static void Main(string[] args)
    {
        int searchedNumber = 10;

        Console.Write("Введите число: ");
        string userInput = Console.ReadLine();

        FindNumber(userInput, searchedNumber);
    }

    static void FindNumber(string userInput, int searchedNumber)
    {
        bool isWorking = true;
        int number;

        while (isWorking)
        {
            int.TryParse(userInput, out number);

            if (number != searchedNumber)
            {
                Console.Write("Конвертация не удалась или введено неверное чило. Введите число снова: ");
                userInput = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Конвертация удалась. Ваше число - " + number);
                isWorking = false;
            }
        }
    }
}