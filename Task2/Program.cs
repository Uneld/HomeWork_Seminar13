
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

string ReleaseMatrix(int[,] matrix, int[] position)
{
    int row = position[0], col = position[1];
    if (row < matrix.GetLength(0) && col < matrix.GetLength(1))
    {
        return $"In element [{row};{col}] = {matrix[row, col]}";
    }
    else
    {
        return $"Element is not found";
    }
}

System.Console.Clear();
int[,] matrix = CreateUserMatrix();
FillMatrix(matrix, -10, 10);
PrintMatrix(matrix);
System.Console.WriteLine("Enter position element");
int[] elementPosition = SingleLineInput(2);
System.Console.WriteLine(ReleaseMatrix(matrix, elementPosition));
