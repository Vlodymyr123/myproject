using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kyrsova
{
    class matrix
    {
        // Fill
        static public double[,] FillMatrix(List<TextBox> tex, int rows, int cols)
        {
            double[,] a = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    a[i, j] = double.Parse(tex[i * cols + j].Text);
                }
            }

            return a;
        }

        // Transpose
        static public double[,] TransposeMatrix(double[,] a ,int rows, int cols)
        {
            double[,] trans = new double[cols, rows];

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    trans[i, j] = a[j, i];
                }
            }

            return trans;
        }

        // Determinant
        static public double Determinant(double[,] a, int rows, int cols)
        {
            if (rows == 1 && cols == 1)
            {
                return a[0, 0];
            }
            else if (rows == 2 && cols == 2)
            {
                return a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0];
            }
            else if (rows >= 3 && cols >= 3)
            {
                double[,] temp = new double[rows - 1, cols - 1];
                double det = 0;
                int q, w;

                for (int j = 0; j < rows; j++)
                {
                    q = 0;
                    for (int k = 1; k < rows; k++)
                    {
                        w = 0;
                        for (int s = 0; s < rows; s++)
                        {
                            if (s != j)
                            {
                                temp[q, w] = a[k, s];
                                w++;
                            }
                        }
                        q++;
                    }
                    det += (Math.Pow(-1, j + 2) * a[0, j] * Determinant(temp, rows - 1, cols - 1));

                }

                return det;
            }
            else
                return 0;
        }

        // Multiply
        static public double[,] MultiplyByNumber(double[,] a, int rows, int cols, double number)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    a[i, j] *= number;
                }
            }
            return a;
        }

        // Multiply ( A x B )
        static public double[,] Multiply(double[,] a, double[,] b, int rows1, int cols1, int cols2)
        {
            double[,] result = new double[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return result;
        }

        // Raise to the pow 
        static public double[,] RaiseToThePow(double[,] a, int rows, int cols, int number)
        {
            if (number == 1)
                return a;
            else if (number % 2 == 1)
                return Multiply(RaiseToThePow(a, rows, cols, number - 1), a, rows, cols, cols);
            else
            {
                a = RaiseToThePow(a, rows, cols, number / 2);
                return Multiply(a, a, rows, cols, cols);
            }
        }

        // Sum (A + B)
        static public double[,] Sum(double[,] a, double[,] b, int rows, int cols)
        {
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }

            return result;
        }

        // Substraction (A - B)
        static public double[,] Substraction(double[,] a, double[,] b, int rows, int cols)
        {
            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }

            return result;
        }
    }
}