double Factorial(int n)
{
    if (n == 1)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}

int Fibonacci(int n)
{
    
    if (n == 1)
    {
        return 1;
    }
    if (n == 2)
    {
        return 1;
    }
    else return Fibonacci(n-1) + Fibonacci(n - 2);
}

System.Console.WriteLine(Fibonacci(6));

