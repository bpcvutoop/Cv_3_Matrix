using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            double[,] e = new double[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            double[,] b = new double[,] { { 7, 8, 5 }, { 9, 10, 6 } };
            double[,] c = new double[,] { { 5, 5, 3 }, { 7, 12, -7 }, { 0, 14, -9 } };
            double[,] d = new double[,] { { 7, 8, 5 }, { 9, 10, 6 }, { 11, 12, 7 } };
            double[,] g = new double[,] { { 1, 1, 3 }, { 3, 3, 3 } };
            double[,] h = new double[,] { { 1, 1 }, { 3, 3 }, { 3, 3 } };
            double[,] ch = new double[,] { { 256, -78 }, { 40, -12 } };


            Matrix matice1 = new Matrix(a);
            Matrix matice2 = new Matrix(b);
            Matrix matice3 = new Matrix(c);
            Matrix matice4 = new Matrix(d);
            Matrix matice5 = new Matrix(e);

            Matrix matice6 = new Matrix(g);
            Matrix matice7 = new Matrix(h);

            Matrix matice8 = new Matrix(ch);

            Console.WriteLine("Soucet matic");
            Console.WriteLine(matice1 + matice2);
            Console.WriteLine();
            Console.WriteLine("Rozdil matic");
            Console.WriteLine(matice1 - matice2);
            Console.WriteLine();
            Console.WriteLine("Soucin matic");
            Console.WriteLine(matice3 * matice4);
            Console.WriteLine();
            Console.WriteLine("Rovnaji se matice?");
            Console.WriteLine(matice1 == matice5);
            Console.WriteLine();
            Console.WriteLine("Nerovnaji se matice?");
            Console.WriteLine(matice1 != matice5);
            Console.WriteLine();
            Console.WriteLine("Zaporna matic");
            Console.WriteLine(-matice3);
            Console.WriteLine();
            Console.WriteLine("Determinanty vsech matic");
            Console.WriteLine(matice1.Determinant());
            Console.WriteLine(matice2.Determinant());
            Console.WriteLine(matice3.Determinant());
            Console.WriteLine(matice4.Determinant());
            Console.WriteLine(matice5.Determinant());
            Console.WriteLine(matice8.Determinant());
            Console.WriteLine();
            Console.WriteLine("Soucin matic ktere nejsou stejne velke");
            Console.WriteLine(matice6 * matice7);
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
