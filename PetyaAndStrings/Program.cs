internal class Program
{
    private static void Main(string[] args)
    {
        char[] a = Console.ReadLine().ToLower().ToCharArray();
        char[] b = Console.ReadLine().ToLower().ToCharArray();
        int result = 0;
        for(int i = 0; i < a.Length; i++)
        {
            if(a[i] != b[i])
            {
                if(a[i] > b[i])
                {
                    result = 1;
                    break;
                }
                else
                {
                    result = -1;
                    break;
                }
            }
        }
        System.Console.WriteLine(result);
    }
}