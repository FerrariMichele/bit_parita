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
                int resto = decimale % 2;
                bin[6 - i] = resto;
                decimale /= 2;
            }
            return bin;
        }
        public static void HParity(ref int[,] matrice, int[] binario, int index)
        {
            int somma = 0;
            for (int i = 0; i < 7; i++)
            {
                matrice[i, index] = binario[i];
                somma += binario[i];
            }
            if (somma%2 == 0)
            {
                matrice[7, index] = 1;
            }
            else
            {
                matrice[7, index] = 0;
            }
        }
        public static void VParity(ref int[,] matrice, int index)
        {
            int somma = 0;
            for (int i = 0; i < 7; i++)
            {
                somma += matrice[index, i];
            }
            if (somma % 2 == 0)
            {
                matrice[index, 7] = 1;
            }
            else
            {
                matrice[index, 7] = 0;
            }
        }
        public static void Visual(int[,] matrice)
        {
            Console.WriteLine();
            for (int k = 0; k < 8; k++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (k != 7)
                    {
                        if (i == 7)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        if (i == 7)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                    }
                    Console.Write($"{matrice[i, k]} ");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            //inserisci un carattere
            int[,] mat1 = new int[8,8];
            char[] inchar = new char[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Inserire carattere: ");
                inchar[i] = Convert.ToChar(Console.ReadLine());
                //calcola il codice ascii di un carattere (funz)
                int dec = ASCII(inchar[i]);
                //conversione in binario (funz)
                int[] bin = Binary(dec);
                //calcolo il bit di parità (funz)
                HParity(ref mat1, bin, i);
            }
            for (int i = 0; i < 7;i++)
            {
                VParity(ref mat1, i);
            }
            //visualizzo
            Visual(mat1);
        }
    }
}
