internal class Program
{
    // Verificar si la primera palabra es igual a la otra escrita al reves
    private static void Main(string[] args)
    {   
        // Primera palabra
        string word = Console.ReadLine();
        // Segunda palabra
        string reverseWord = Console.ReadLine();
        // Chequear si son del mismo tamano
        if(word.Length != reverseWord.Length)
        {
            Console.WriteLine("NO");
            return;
        }
        // Chequeo cada posicion desde el inicio de la primera palabra vs desde el final de la segunda palabra
        for(int i = 0; i < word.Length; i++)
        {
            // Chequeo si son diferentes retorno que "NO"
            if(word[i] != reverseWord[word.Length - i - 1]){
                Console.WriteLine("NO");
                return;
            }
        }
        // Luego retorno "YES"
        Console.WriteLine("YES");
    }
}