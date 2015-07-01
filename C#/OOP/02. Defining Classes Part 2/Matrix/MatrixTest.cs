namespace Matrix
{
    using System;

    class MatrixTest
    {
        static void Main(string[] args)
        {
            Matrix<int> firstMatrix = new Matrix<int>(4, 3);
            Matrix<int> secondMatrix = new Matrix<int>(3, 2);

            firstMatrix[0, 0] = 1;                                //
            firstMatrix[0, 1] = -1;                               //
            firstMatrix[1, 1] = 2;                                //
            firstMatrix[1, 2] = 3;                                // Fills first matrix
            firstMatrix[2, 0] = 1;                                //
            firstMatrix[2, 1] = -3;                               //
            firstMatrix[2, 2] = 1;                                //
            firstMatrix[3, 0] = 4;                                //
            firstMatrix[3, 2] = 2;                                //

            Console.WriteLine("First matrix:");
            PrintMatrix(firstMatrix);

            secondMatrix[0, 0] = 2;                               // 
            secondMatrix[0, 1] = 1;                               // 
            secondMatrix[1, 0] = -1;                              // Fills second matrix
            secondMatrix[2, 0] = 3;                               // 
            secondMatrix[2, 1] = 1;                               // 

            Console.WriteLine("\nSecond matrix:");
            PrintMatrix(secondMatrix);

            Matrix<int> multiplyResult = firstMatrix * secondMatrix;

            Console.WriteLine("\nMultiplication result:");
            PrintMatrix(multiplyResult);


            firstMatrix = new Matrix<int>(2, 2);
            secondMatrix = new Matrix<int>(2, 2);

            firstMatrix[0, 0] = -3;                               //
            firstMatrix[0, 1] = 4;                                // Fills new first matrix
            firstMatrix[1, 0] = 2;                                //
            firstMatrix[1, 1] = -1;                               //

            Console.WriteLine("\nNew first matrix:");
            PrintMatrix(firstMatrix);

            secondMatrix[0, 0] = 5;                               //
            secondMatrix[0, 1] = 3;                               // Fills new second matrix
            secondMatrix[1, 0] = 3;                               //
            secondMatrix[1, 1] = -2;                              //

            Console.WriteLine("\nNew second matrix:");
            PrintMatrix(secondMatrix);
                 
            Matrix<int> addResult = firstMatrix + secondMatrix;

            Console.WriteLine("\nAddition result:");
            PrintMatrix(addResult);

            Matrix<int> subResult = firstMatrix - secondMatrix;

            Console.WriteLine("\nSubtraction result:");
            PrintMatrix(subResult);
        }

        static void PrintMatrix(Matrix<int> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    Console.Write("{0,2} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }


    }
}
