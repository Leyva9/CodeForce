internal class Program
{
    private static void Main(string[] args)
    {
        string word = Console.ReadLine();
        string wordCapitalized = word.ToUpper();
        string result = wordCapitalized[0].ToString();

        for(int i = 1; i < word.Length; i++)
        {
            result+=word[i].ToString();
        }
        System.Console.WriteLine(result);
    }
}