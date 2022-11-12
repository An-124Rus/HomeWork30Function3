internal class Program
{
    private static void Main(string[] args)
    {
        int number = ReturnNumber();

        Console.WriteLine("Конвертация удалась. Ваше число - " + number);
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
}