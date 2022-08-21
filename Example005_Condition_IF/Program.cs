internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите имя пользователя:");
        string username = Console.ReadLine();

        if (username == "Маша") ;
        {
            Console.WriteLine("Ура, это же Маша");
        }
else
        {
            Console.Write("Привет, ");
            Comsole.WriteLine(username);
        }
    }
}