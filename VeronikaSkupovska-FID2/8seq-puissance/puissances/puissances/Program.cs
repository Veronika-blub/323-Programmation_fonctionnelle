// See https://aka.ms/new-console-template for more information
static int Puissance(int nombre, int exposant)
{
    if (exposant == 0) return 1;
    
    return nombre * Puissance(nombre, exposant - 1);
}
Console.WriteLine(Puissance(2, 3));


//  static int Fibonacci(int n)
// {
//     int n1 = n;
//      if (n > 100) return n;

//     return n + Fibonacci(n);
     
//  }
//  Console.WriteLine(Fibonacci(2));

static List<int> Fibonacci(int n)
{
    var seq = new List<int>();
    if (n <= 0) return seq; 
    seq.Add(0);
    if (n == 1) return seq;
    seq.Add(1);
    for (int i = 2; i < n; i++)
        seq.Add(seq[i - 1] + seq[i - 2]);
    return seq;
}
Console.WriteLine(string.Join(", ", Fibonacci(0)));