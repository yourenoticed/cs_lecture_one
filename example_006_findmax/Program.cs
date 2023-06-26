int[] numbers = {39, 25, 13, 42, 32, 13, 52, 14, 15};

int Max(int[] digits)
{
    int maximum = digits[0];
    for (int i = 1; i < digits.Length; i++)
    {
        if (maximum < digits[i])
        {
            maximum = digits[i];
        }
    }
    return maximum;
}
Console.WriteLine(Max(numbers));
