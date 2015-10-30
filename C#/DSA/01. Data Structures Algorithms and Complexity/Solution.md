# Problem 01.
```c#
long Compute(int[] arr)
{
    long count = 0;
    for (int i=0; i<arr.Length; i++)
    {
        int start = 0, end = arr.Length-1;
        while (start < end)
            if (arr[start] < arr[end])
                { start++; count++; }
            else 
                end--;
    }
    return count;
}
```
For the array of size `n` the outer for-loop is of complexity `O(n)` and the complexity of the inner while-loop is also `O(n)`. For each iteration of the outer loop, there will be a whole traversal of the inner loop so the whole algorithm (ignoring the constant complexities of the inner operations) will be of complexity `O(n^2)`.

# Problem 02.
```c#
long CalcCount(int[,] matrix)
{
    long count = 0;
    for (int row=0; row<matrix.GetLength(0); row++)
        if (matrix[row, 0] % 2 == 0)
            for (int col=0; col<matrix.GetLength(1); col++)
                if (matrix[row,col] > 0)
                    count++;
    return count;
}
```
For the matrix of size `n * m` the complexity of the outer for-loop is `O(n)` and the complexity of the inner for-loop is also `O(m)`. The inner loop is called every second iteration of the outer loop so the combined complexities of the loops are `O(n * m / 2)` but since `2` is a constant we drop it and the final complexity of the algorithm is `O(n * m)`.

# Problem 03.
```c#
long CalcSum(int[,] matrix, int row)
{
    long sum = 0;
    for (int col = 0; col < matrix.GetLength(0); col++) 
        sum += matrix[row, col];
    if (row + 1 < matrix.GetLength(1)) 
        sum += CalcSum(matrix, row + 1);
    return sum;
}

Console.WriteLine(CalcSum(matrix, 0));
```
For the matrix of size `n * m` the complexity of the outer for-loop is `O(n)` but when starting from the first (zeroth) row, we're recursively calculating the sum until the final row, so the method will be called `m` times which is of complexity `O(m)` so the whole complexity of the algorithm is `O(n * m)`.