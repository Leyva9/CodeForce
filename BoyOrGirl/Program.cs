internal class Program
{
    private static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int count = name.Length;
        bool[] word = new bool[name.Length];
        for(int i = 0; i < name.Length; i++)
        {
            for(int j = i+1; j < name.Length; j++)
            {
                if(name[i] == name[j] && !word[j])
                {
                    count--;
                    word[j] = true;
                }
            }
        }
        if(count%2 == 0)
        {
            System.Console.WriteLine("CHAT WITH HER!");
        }
        else
        {
            System.Console.WriteLine("IGNORE HIM!");
        }
    }
}