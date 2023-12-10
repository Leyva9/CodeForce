internal class Program
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        
        for(int i = 0; i < n; i++)
        {
            int aux = 0;
            string? number = Console.ReadLine();
            for(int j = 0; j < 6; j+=2)
            {
                if(number?[j] == '1')
                {
                    aux++;
                }
                if(aux > 1)
                {
                    count++;
                    break;
                }
            }
        }
        System.Console.WriteLine(count);
    }
}