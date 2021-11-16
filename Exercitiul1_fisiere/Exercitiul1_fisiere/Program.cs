
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Exercitiul1_fisiere
{
    class Program
    {
        public static void LoadVector()
        {
            TextReader load = new StreamReader("test.txt.txt");
            int n = int.Parse(load.ReadLine());
            string[] auxV = null;                    // vectorul null in care citesti cu ReadLine()
            int[] V = new int[n];
            auxV = load.ReadLine().Split(' ');        ///citesti si faci split dupa spatii.Poti folosi si vectorul auxV numai ca are elemente de tip string
            for (int i = 0; i < n; i++)
            {
                V[i] = int.Parse(auxV[i]);    //copii si faci cast la int in vectorul V
                Console.Write(V[i] + " ");
            }
            load.Close();
        }
        public static void LoadMatrice()  // cirtirea in cazul in care ni se da punctele vizitate( facem matricea de adiacenta
        {
             int[,] matrix;
             int varfuri;
            string line;
            char[] seps = { ' ', '\t', '\n' };
            using (StreamReader sr = new StreamReader("test1.txt.txt"))
            {
                string[] tokens;
                line = sr.ReadLine();
                varfuri = int.Parse(line);
                matrix = new int[varfuri, varfuri];
                while ((line = sr.ReadLine()) != null)
                {
                    tokens = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);
                    int i = int.Parse(tokens[0]);
                    int j = int.Parse(tokens[1]);
                    matrix[i - 1, j - 1] = 1;
                    matrix[j - 1, i - 1] = 1;
                }
            }
            for (int i = 0; i < varfuri; i++)
            {
                for (int j = 0; j < varfuri; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }

        }
        public static void LoadMatriceData()
        {
            using (StreamReader sr = new StreamReader("test2.txt.txt"))
            {
                string sLineOne = sr.ReadLine();
                string[] split = sLineOne.Split(' ');
                int x = Int32.Parse(split[0]);
                int y = Int32.Parse(split[1]);

                int[,] matrice = new int[x, y];

                for (int i = 0; i < x; i++)
                {
                    split = sr.ReadLine().Split(' ');

                    for (int j = 0; j < y; j++)
                    {
                        matrice[i, j] = Int32.Parse(split[j]);
                    }

                }
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                        Console.Write(matrice[i, j] + " ");
                    Console.WriteLine();
                }
            }

        }
        public static void Main(string[] args)
        {
           LoadMatriceData();
        }
    }
}
