namespace Matrix
{
    using System;
    using System.Text;

    public class Matrix<T>
    {
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
            this.Rows = rows;
            this.Cols = cols;
        }

        public int Rows { get; set; }

        public int Cols { get; set; }

        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row >= this.Rows) || (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }

                return this.matrix[row, col];
            }

            set
            {
                if ((row < 0 || row >= this.Rows) || (col < 0 || col >= this.Cols))
                {
                    throw new IndexOutOfRangeException();
                }

                this.matrix[row, col] = value;
            }
        }

        // Addition
        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new Exception("Matrices are not the same size!");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    result[i, j] = (dynamic)matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        // Subtraction
        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new Exception("Matrices are not the same size!");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    result[i, j] = (dynamic)matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Cols != matrix2.Rows)
            {
                throw new Exception("The matrices cannot be multiplied.");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix2.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    for (int t = 0; t < matrix1.Cols; t++)
                    {
                        result[i, j] += (dynamic)matrix1[i, t] * matrix2[t, j];
                    }
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            return OverrideBool(matrix);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return OverrideBool(matrix);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    result.AppendFormat("{0,4}", this.matrix[i, j]);
                }

                result.AppendLine();
            }

            return result.ToString();
        }

        private static bool OverrideBool(Matrix<T> matrix)
        {
            bool isZero = true;

            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] == (dynamic)0)
                    {
                        isZero = false;
                    }
                }
            }

            return isZero;
        }
    }
}