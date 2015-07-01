namespace Matrix
{
    using System;

    public class Matrix<T>
        where T : IComparable<T>
    {
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Cols
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if (row >= 0 && row < this.matrix.GetLength(0)
                    && col >= 0 && col < this.matrix.GetLength(1))
                {
                    return this.matrix[row, col];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (row >= 0 && row < this.matrix.GetLength(0)
                   && col >= 0 && col < this.matrix.GetLength(1))
                {
                    this.matrix[row, col] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if ((matrixOne.Cols != matrixTwo.Cols)
                || (matrixTwo.Rows != matrixOne.Rows))
            {
                throw new Exception("Matrices with different sizes cannot be added!");
            }

            Matrix<T> newMatrix = new Matrix<T>(matrixOne.Rows, matrixOne.Cols);

            for (int row = 0; row < matrixOne.Rows; row++)
            {
                for (int col = 0; col < matrixOne.Cols; col++)
                {
                    newMatrix[row, col] = (dynamic)matrixOne[row, col] + matrixTwo[row, col];
                }
            }

            return newMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if ((matrixOne.Cols != matrixTwo.Cols)
                || (matrixTwo.Rows != matrixOne.Rows))
            {
                throw new Exception("Matrices with different sizes cannot be subtracted!");
            }

            Matrix<T> newMatrix = new Matrix<T>(matrixOne.Rows, matrixOne.Cols);

            for (int row = 0; row < matrixOne.Rows; row++)
            {
                for (int col = 0; col < matrixOne.Cols; col++)
                {
                    newMatrix[row, col] = (dynamic)matrixOne[row, col] - matrixTwo[row, col];
                }
            }

            return newMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.Cols != matrixTwo.Rows)
            {
                throw new Exception("Matrices have invalid sizes for multiplication purpose.");
            }

            int cellSum;
            Matrix<T> newMatrix = new Matrix<T>(matrixOne.Rows, matrixTwo.Cols);

            for (int newRow = 0; newRow < newMatrix.Rows; newRow++)
            {
                for (int newCol = 0; newCol < newMatrix.Cols; newCol++)
                {
                    cellSum = 0;

                    for (int i = 0; i < matrixOne.Cols; i++)
                    {
                        cellSum += (dynamic)matrixOne[newRow, i] * matrixTwo[i, newCol];
                    }

                    newMatrix[newRow, newCol] = (dynamic)cellSum;
                }
            }

            return newMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
			{
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] != (dynamic)0)
                    {
                        return true;
                    }
                }
			}

            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
