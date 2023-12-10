internal class Program
{
    private static void Main(string[] args)
    {
        (int,int) center = (2,2);
        (int,int) place = (0,0);
        int result = 0;
        for(int i = 0; i < 5; i++)
        {
            string[] rowNumbs = Console.ReadLine().Split(' ');
            for(int j = 0; j < rowNumbs.Length; j++)
            {
                if(rowNumbs[j] == "1")
                {
                    place.Item1 = i;
                    place.Item2 = j;
                }
            }
        }
        result = Math.Abs(center.Item1 - place.Item1) + Math.Abs(center.Item2 - place.Item2);
        System.Console.WriteLine(result);
    }
}