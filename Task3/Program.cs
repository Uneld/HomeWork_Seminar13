
void PrintArrayDouble(double[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int[] SingleLineInput(int reqSizeArray)
{
    int[] array;
    System.Console.WriteLine("Enter single line array with a \"space\"");
    do
    {
        array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
        if (array.Length != reqSizeArray)
        {
            System.Console.WriteLine("Wrong enter, please try again");
        }
    } while (array.Length != reqSizeArray);
    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            System.Console.Write($"{matrix[rows, columns]} \t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FillMatrix(int[,] matrix, int min, int max)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(min, max + 1);
        }
    }
}

int[,] CreateUserMatrix()
{
    System.Console.WriteLine("Enter size matrix");
    int[] size = SingleLineInput(2);
    return new int[size[0], size[1]];
}

double[] ReleaseMatrix(int[,] matrix)
{
    double[] rowsAvrSum = new double[matrix.GetLength(1)];
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            rowsAvrSum[columns] += matrix[rows, columns];
        }
        rowsAvrSum[columns] /= matrix.GetLength(0);
    }
    return rowsAvrSum;
}

System.Console.Clear();
int[,] matrix = CreateUserMatrix();
FillMatrix(matrix, 1, 10);
PrintMatrix(matrix);
System.Console.WriteLine("Sum all rows:");
PrintArrayDouble(ReleaseMatrix(matrix));
