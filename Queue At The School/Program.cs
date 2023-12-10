internal class Program
{
    private static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(" ");
        int seconds = Convert.ToInt32(input[1]);
        char[] cola = Console.ReadLine().ToArray();

        for(int i = 0; i < seconds; i++) {
            for(int j = cola.Length-1; j > 0; j--) {
                if(cola[j] == 'G' && cola[j-1] == 'B') {
                    char aux = cola[j-1];
                    cola[j-1] = cola[j];
                    cola[j] = aux;
                    j--;
                }
            }
        }
        Console.WriteLine(String.Concat(cola));
    }
    // BBGBBG BBGBGB BGBBGB GBBGBB
}