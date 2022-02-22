using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_03
{
    public class Matrix
    {
        private double[,] matrixArray;

        public Matrix(double[,] MatrixArray)
        {
            this.matrixArray = MatrixArray;
        }

        public static Matrix operator +(Matrix x, Matrix y)
        {
            //abychom je mohli secist musi byt obe matice stejne velke (dimenze 0 a dimenze 1)
            if ((x.matrixArray.GetLength(0) == y.matrixArray.GetLength(0)) && (x.matrixArray.GetLength(1) == y.matrixArray.GetLength(1)))
            {
                Matrix f = new Matrix(new double[x.matrixArray.GetLength(0), x.matrixArray.GetLength(1)]); //vytvoreni pomocne matice o velikosti scitanych matic

                for (int i = 0; i < x.matrixArray.GetLength(0); i++)
                {
                    for (int j = 0; j < x.matrixArray.GetLength(1); j++)
                    {
                        f.matrixArray[i, j] = x.matrixArray[i, j] + y.matrixArray[i, j];
                    }
                }

                return f;
            }
            else
            {
                throw new Exception("These matrixs are not compatible for this operation (NOT THE SAME SIZE)");
        
            }

        }

        public static Matrix operator -(Matrix x, Matrix y)
        {
            //abychom je mohli secist musi byt obe matice stejne velke (dimenze 0 a dimenze 1)
            if ((x.matrixArray.GetLength(0) == y.matrixArray.GetLength(0)) && (x.matrixArray.GetLength(1) == y.matrixArray.GetLength(1)))
            {
                Matrix f = new Matrix(new double[x.matrixArray.GetLength(0), x.matrixArray.GetLength(1)]); //vytvoreni pomocne matice o velikosti scitanych matic

                for (int i = 0; i < x.matrixArray.GetLength(0); i++)
                {
                    for (int j = 0; j < x.matrixArray.GetLength(1); j++)
                    {
                        f.matrixArray[i, j] = x.matrixArray[i, j] - y.matrixArray[i, j];
                    }
                }

                return f;
            }
            else
            {
                throw new Exception("These matrixs are not compatible for this operation (NOT THE SAME SIZE)");
            }

        }

        public static Matrix operator -(Matrix x)
        {
            Matrix f = new Matrix(new double[x.matrixArray.GetLength(0), x.matrixArray.GetLength(1)]);
            for (int i = 0; i < x.matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < x.matrixArray.GetLength(1); j++)
                {
                    f.matrixArray[i, j] = (-1) * x.matrixArray[i, j];
                }
            }
            return f;
        }

        public static Matrix operator *(Matrix x, Matrix y)
        {

            if (x.matrixArray.GetLength(0) == y.matrixArray.GetLength(1))
            {
                Matrix f = new Matrix(new double[x.matrixArray.GetLength(0), y.matrixArray.GetLength(1)]); //vytvoreni pomocne matice o velikosti scitanych matic

                for (int i = 0; i < x.matrixArray.GetLength(0); i++)
                {
                    for (int j = 0; j < y.matrixArray.GetLength(1); j++)
                    {
                        for (int k = 0; k < x.matrixArray.GetLength(1); k++)
                        {
                            f.matrixArray[i, j] += x.matrixArray[i, k] * y.matrixArray[k, j];
                        }
                    }
                }
                return f;
            }
            else
            {
                throw new Exception("These matrixs are not compatible for this operation");

            }
        }

        public static bool operator ==(Matrix x, Matrix y)
        {

            if ((x.matrixArray.GetLength(0) == y.matrixArray.GetLength(0)) && (x.matrixArray.GetLength(1) == y.matrixArray.GetLength(1)))
            {
                for (int i = 0; i < x.matrixArray.GetLength(0); i++)
                {
                    for (int j = 0; j < x.matrixArray.GetLength(1); j++)
                    {
                        if (x.matrixArray[i, j] != y.matrixArray[i, j])
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        public static bool operator !=(Matrix x, Matrix y)
        {
            return !(x == y);
            /*if (x == y)
            {
                return false;
            }
            else
            {
                return true;
            }*/
        }

        public double Determinant()
        {
            if (matrixArray.GetLength(0) == matrixArray.GetLength(1))
            {
                switch (matrixArray.GetLength(0))
                {
                    case 1:
                        {
                            return matrixArray[0, 0];
                            break;
                        }

                    case 2:
                        {
                            return ((matrixArray[0, 0] * matrixArray[1, 1]) - (matrixArray[0, 1] * matrixArray[1, 0]));
                            break;
                        }

                    case 3:
                        {
                            double a = ((matrixArray[0, 0] * matrixArray[1, 1] * matrixArray[2, 2]) - (matrixArray[0, 2] * matrixArray[1, 1] * matrixArray[2, 0]));
                            double b = ((matrixArray[1, 0] * matrixArray[2, 1] * matrixArray[0, 2]) - (matrixArray[1, 2] * matrixArray[2, 1] * matrixArray[0, 0]));
                            double c = ((matrixArray[2, 0] * matrixArray[0, 1] * matrixArray[1, 2]) - (matrixArray[1, 0] * matrixArray[0, 1] * matrixArray[2, 2]));
                            return a + b + c;
                            break;

                        }
                    
                }
            }
            throw new Exception("These matrixs are not compatible for this operation");


        }

        public override string ToString()
        {
            string vypis = "";

            for (int i = 0; i < matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray.GetLength(1); j++)
                {
                    if (j==0)
                    {
                        vypis = vypis + matrixArray[i, j];

                    }
                    else
                    {
                        vypis = vypis + " " + matrixArray[i, j];
                    }
                }
                vypis += Environment.NewLine;
            }
            return vypis;
        }




    }
}

