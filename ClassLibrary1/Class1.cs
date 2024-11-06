using System;

namespace ClassLibrary1
{
    public class SquareMatrix
    {
        public double[,] matrix;

        public int Dimension { get; private set; }

        public SquareMatrix(int dimension) //создает квадратную матрицу заданного размера dimension и заполняет ее случайными числами от 0 до 10.
        {
            Dimension = dimension;
            matrix = new double[dimension, dimension];
            Random random = new Random();

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    matrix[i, j] = random.NextDouble() * 10; // Заполнение матрицы рандомными числами от 0 до 10
                }
            }
        }

        public SquareMatrix(double[,] values) //создает квадратную матрицу на основе переданных значений.
        {
            Dimension = values.GetLength(0);
            matrix = new double[Dimension, Dimension];
            Array.Copy(values, matrix, values.Length);
        }

        public double this[int i, int j] //позволяет получить или установить значение элемента матрицы по указанным координатам.
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        public double CalculateDiagonalProduct(params int[] diagonals)
        {
            double result = 1;

            if (diagonals.Length > 0)
            {
                foreach (int diagonal in diagonals)
                {
                    for (int i = 0; i < Dimension; i++)
                    {
                        int j = i + diagonal;
                        if (j >= 0 && j < Dimension)
                        {
                            result *= matrix[i, j];
                        }
                    }
                }
            }
            else
            {
                for (int d = -Dimension + 1; d < Dimension; d++)
                {
                    for (int i = 0; i < Dimension; i++)
                    {
                        int j = i + d;
                        if (j >= 0 && j < Dimension)
                        {
                            result += matrix[i, j];
                        }
                    }
                }
            }

            return result;
        }
        public double this[int i]
        {
            get
            {
                int row = i / Dimension;
                int col = i % Dimension;
                return matrix[row, col];
            }
            set
            {
                int row = i / Dimension;
                int col = i % Dimension;
                matrix[row, col] = value;
            }
        }


    }
}