internal class Program
{
    private static void Main(string[] args)
    {
        string[]? data = Console.ReadLine().Split(' ');

        int players, minPoints, aux;
        int.TryParse(data[0].ToString(), out players);
        int.TryParse(data[1].ToString(), out minPoints);
        minPoints--;
        
        string[]? scores = Console.ReadLine().Split(' ');

        int.TryParse(scores[minPoints], out minPoints);

        int playersNextRound = 0;
        for(int i = 0; i < scores.Length; i++)
        {
            int.TryParse(scores[i], out aux);
            if(aux >= minPoints && aux != 0)
            {
                playersNextRound++;
            }
        }
        System.Console.WriteLine(playersNextRound);
    }
}