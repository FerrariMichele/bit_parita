using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bit_parita
{
    internal class Program
    {
        public static int ASCII(char carattere)
        {
            return (int)carattere;
        }
        public static int[] Binary(int decimale)
        {
            int[] bin = new int[8];
            for (int i = 0; i < 7; i++)
            {
                int resto = decimale % 2; ;
                bin[6 - i] = resto;
                decimale /= 2;
            }
            return bin;
        }
        public static int Parity(int[] binario)
        {
            int somma = 0;
            for (int i = 0; i < 7; i++)
            {
                somma += binario[i];
            }
            if (somma%2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static void Visual(int[] binario, int bitparita)
        {
            for (int i = 0; i < 7; i++)
            {
                Console.Write(binario[i]);
            }
            Console.Write(bitparita);
        }
        static void Main(string[] args)
        {
            int[,] mat = new int[7,7];
            for (int i = 0; i < 7; i++)
            {
                //inserisci un carattere
                Console.WriteLine("Inserire carattere: ");
                char inchar = (char)Console.Read();
                //calcola il codice ascii di un carattere (funz)
                int dec = ASCII(inchar);
                //conversione in binario (funz)
                int[] bin = Binary(dec);
                //calcolo il bit di parità (funz)
                int p = Parity(bin);
                //visualizzo
                Visual(bin, p);
            }
        }
    }
}
