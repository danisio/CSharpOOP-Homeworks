namespace Matrix
{
    using System;

    public class TestMatrix
    {
        static Random rnd = new Random();

        public static void Main()
        {
            // add an instance of Matrix and set random numbers
            Matrix<int> matrix1 = new Matrix<int>(3, 3);
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    matrix1[i, j] = rnd.Next(1, 10);
                }
            }

            // add another instance of Matrix and set random numbers
            Matrix<int> matrix2 = new Matrix<int>(3, 3);
            for (int i = 0; i < matrix2.Rows; i++)
            {
                for (int j = 0; j < matrix2.Cols; j++)
                {
                    matrix2[i, j] = rnd.Next(0, 10);
                }
            }

            // test methods Addition(), Subtraction() and Multiplication()
            Matrix<int> addition = matrix1 + matrix2;
            Matrix<int> subtraction = matrix1 - matrix2;
            Matrix<int> multiplication = matrix1 * matrix2;

            // print all matrices
            Console.WriteLine("Matrix 1:\n" + matrix1.ToString());
            Console.WriteLine("Matrix 2:\n" + matrix2.ToString());
            Console.WriteLine("Addition matrix:\n" + addition.ToString());
            Console.WriteLine("Subtraction matrix:\n" + subtraction.ToString());
            Console.WriteLine("Multiplication matrix:\n" + multiplication.ToString());

            // check for zero elements
            Console.WriteLine("Metrix 1 doesn't contain zero elements --> {0}", matrix1 ? true : false);
            Console.WriteLine("Metrix 2 doesn't contain zero elements --> {0}", matrix2 ? true : false);
        }
    }
}
