namespace AS2324.Antonio.Russo._3G.es13.lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("quante persone voi inserire ");
            int dimensione  = Convert.ToInt32(Console.ReadLine());
            int[] peso = new int[dimensione];
            int[] eta  = new int[dimensione];
            Console.WriteLine("riempimento");
            for (int i = 0; i < peso.Length ; i++)
            {
                Console.WriteLine($"peso persona { i + 1}");
                peso[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"eta persona {i + 1}");
                eta[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}