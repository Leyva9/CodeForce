internal class Program
{
    private static void Main(string[] args)
    {
        string[] matriz = Console.ReadLine().Split(' ');
        int[] matrizNumber = new int[matriz.Length];
        int lenght = 0;
        for(int i = 0; i < matriz.Length; i++)
        {
            int.TryParse(matriz[i], out matrizNumber[i]);
        }
        lenght = matrizNumber[0] * matrizNumber[1];
        System.Console.WriteLine(lenght/2);
    }
}