using System;

namespace AS2324.Antonio.Russo._3G.es13.lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media = 0;
            double min = 0;
            double max = 0;

            Console.WriteLine("quante persone voi inserire ");
            int dimensione = Convert.ToInt32(Console.ReadLine());
            int[] peso = new int[dimensione];
            int[] eta = new int[dimensione];
            Console.WriteLine("riempimento");

            CaricaVettori(ref peso, ref eta);
            Statistiche(ref peso, ref media, ref min, ref max);
            
            Console.WriteLine($" media:  {media}");
            Console.WriteLine($" minimo:  {min}");
            Console.WriteLine($" massimo:  {max}");
            Ordina(ref  peso, ref eta);
            for(int i = 0; i < peso.Length; i++)
            {
                Console.WriteLine($"\t peso persona {i +1 } :{peso[i]}");
                Console.WriteLine($"\t eta persona {i + 1} :{eta[i]}");
            }
           
        }
        static void CaricaVettori(ref int[] peso,ref int[] eta)
        {
            for (int i = 0; i < peso.Length; i++)
            {
                do
                {
                    Console.WriteLine($"peso persona {i + 1} tra 50 Kg a 100kg");
                    peso[i] = Convert.ToInt32(Console.ReadLine());
                } while (peso[i] < 50 || peso[i] > 100);


                do
                {
                    Console.WriteLine($"eta persona {i + 1} tra 18 a 99");
                    eta[i] = Convert.ToInt32(Console.ReadLine());
                } while (eta[i] < 18 || eta[i] > 99);
            }
        }
        static void Statistiche(ref int[] peso, ref double media,ref double min,ref double max)
        {
            int somma = 0;
            for(int i = 0;i < peso.Length;i++)
            {
                somma  += peso[i];
            }
            media = somma / peso.Length;

            max = peso[0];
            for (int i = 1; i < peso.Length; i++)
            {
                if (peso[i] > max)
                {
                    max = peso[i];
                }
            }
            min = peso[0];
            for (int i = 1; i < peso.Length; i++)
            {
                if (peso[i] < min)
                {
                    min = peso[i];
                }
            }
        }
        static void Ordina(ref int[] peso, ref int[] eta)
        {
            for (int i = 0; i < peso.Length; i++)
            {
                int minIndex = i;
                for(int j = 0; j < peso.Length; j++)
                {
                    if (peso[j] < peso[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = peso[minIndex];
                peso[minIndex] = peso[i];
                peso[i] = temp;

                int temp1 = eta[minIndex];
                eta[minIndex] = eta[i];
                eta[i] = temp1;



            }

        }
    }
}