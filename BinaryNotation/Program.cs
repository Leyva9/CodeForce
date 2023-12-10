internal class Program
{
    private static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        string binaryNumb = "";

        if(number == 0) {
            Console.WriteLine("0");
            return;
        }
        else {
            while(number > 0)
            {
                binaryNumb = (number%2).ToString() + binaryNumb;
                number /= 2;
            }
        }
        binaryNumb.Reverse();
        Console.WriteLine(binaryNumb);
    }
}