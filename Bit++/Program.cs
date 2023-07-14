internal class Program
{
    private static void Main(string[] args)
    {
        int numOperations = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        for(int i = 0; i < numOperations; i++)
        {
            string argument = Console.ReadLine();
            for(int j = 0; j < argument.Length; j++)
            {
                if(argument[j] == '+')
                {
                    result++;
                    break;
                }
                if(argument[j] == '-')
                {
                    result--;
                    break;
                }
            }
        }
        System.Console.WriteLine(result);
    }
}