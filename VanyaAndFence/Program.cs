internal class Program
{
    private static void Main(string[] args)
    {
        int[] ageAndHeight = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] heigths = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int totalWidth = 0;
        for(int i = 0; i < heigths.Length; i++)
        {   
            if(heigths[i] > ageAndHeight[1])
            {
                totalWidth+=2;
            }
            else {
                totalWidth++;
            }
        }
        Console.WriteLine(totalWidth);
    }
}