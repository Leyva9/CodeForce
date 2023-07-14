internal class Program
{
    private static void Main(string[] args)
    {
        string[] sum = Console.ReadLine().Split('+');
        int[] newSum = new int[sum.Length];
        string result = "";
        for(int i = 0; i < newSum.Length; i++)
        {
            int.TryParse(sum[i], out newSum[i]);
        }
        Array.Sort(newSum);
        for(int i = 0; i < newSum.Length; i++)
        {
            if(i != newSum.Length - 1)
            {
                result+=newSum[i]+"+";
            }
            else{
                result+=newSum[i];
            }
        }
        System.Console.WriteLine(result);
    }
}